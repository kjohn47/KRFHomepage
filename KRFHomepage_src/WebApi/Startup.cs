namespace KRFHomepage.WebApi
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;

    using KRFCommon.Context;
    using KRFCommon.Handler;
    using KRFCommon.Swagger;
    using KRFCommon.Constants;
    using KRFCommon.Api;
    using KRFCommon.Database;

    using KRFHomepage.App.Injection;
    using KRFHomepage.App.Model;
    using KRFCommon.MemoryCache;

    public class Startup
    {
        public Startup( IConfiguration configuration, IWebHostEnvironment env )
        {
            this.Configuration = configuration;
            this._apiSettings = configuration.GetSection( KRFApiSettings.AppConfiguration_Key ).Get<AppConfiguration>();
            this._requestContext = configuration.GetSection( KRFApiSettings.RequestContext_Key ).Get<RequestContext>();
            this._databases = configuration.GetSection( KRFApiSettings.KRFDatabases_Key ).Get<KRFDatabases>();
            this._enableLogs = configuration.GetValue( KRFApiSettings.LogsOnPrd_Key, false );
            this._cacheMemorySettings = configuration.GetSection( KRFApiSettings.MemoryCacheSettings_Key ).Get<MemoryCacheSettings>() ?? new MemoryCacheSettings();

            this.HostingEnvironment = env;
        }

        private readonly AppConfiguration _apiSettings;
        private readonly RequestContext _requestContext;
        private readonly KRFDatabases _databases;
        private readonly bool _enableLogs;
        private readonly MemoryCacheSettings _cacheMemorySettings;

        public IWebHostEnvironment HostingEnvironment { get; }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices( IServiceCollection services )
        {
            //Add logger config
            services.AddLogging( l =>
             {
                 var config = this.Configuration.GetSection( KRFApiSettings.Logging_Key );
                 l.ClearProviders();
                 l.AddConfiguration( config );
                 l.AddConsole();
                 l.AddDebug();
                 l.AddEventLog();
                 l.AddEventSourceLogger();
             } );

            services.InjectUserContext( this._apiSettings.TokenIdentifier, this._apiSettings.TokenKey );

            services.AddControllers();

            services.SwaggerInit( this._apiSettings.ApiName, this._apiSettings.TokenKey );

            services.InjectMemoryCache( this._cacheMemorySettings );

            //Dependency injection
            services.InjectAppDBContext( this._databases );
            services.InjectAppQueries();
            services.InjectAppCommands();
            services.InjectAppProxies();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure( IApplicationBuilder app, ILoggerFactory loggerFactory )
        {
            //server config settings
            var enableLogs = this._enableLogs;


            if ( this.HostingEnvironment.IsDevelopment() )
            {
                app.UseDeveloperExceptionPage();
                enableLogs = true;
            }

            if ( enableLogs && this._requestContext.EnableRead )
            {
                app.UseMiddleware<KRFBodyRewindMiddleware>( this._requestContext.BufferSize, this._requestContext.MemBufferOnly );
            }

            if ( this._requestContext.EnableRead && this._requestContext.MemBufferOnly )
            {
                app.KRFExceptionHandlerMiddlewareConfigure( loggerFactory, enableLogs, this._apiSettings.ApiName, this._apiSettings.TokenIdentifier, this._requestContext.BufferSize );
            }
            else
            {
                app.KRFExceptionHandlerMiddlewareConfigure( loggerFactory, enableLogs, this._apiSettings.ApiName, this._apiSettings.TokenIdentifier );
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.AuthConfigure();

            app.UseEndpoints( endpoints =>
             {
                 endpoints.MapControllers();
             } );

            app.SwaggerConfigure( this._apiSettings.ApiName );

            app.ConfigureAppDBContext( this._databases );
        }
    }
}