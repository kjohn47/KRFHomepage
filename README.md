KRFHomepage

Important:
Add KRFCommon nuget repository
*you can add nuget.config file to solution root or add to your user for use in all projects on file bellow
C:\Users\[your_username]\AppData\Roaming\NuGet\NuGet.Config

Add your repository for nugget generated from KRFCommon project (example github)

    <packageSources>
        <clear />
        <add key="github" value="https://nuget.pkg.github.com/kjohn47/index.json" />
        <add key="Nuget.org" value="https://api.nuget.org/v3/index.json" />
    </packageSources>
    <packageSourceCredentials>
        <github>
            <add key="Username" value="###USERNAME###" />
            <add key="ClearTextPassword" value="###TOKEN###" />
        </github>
    </packageSourceCredentials>

Set WebApi as startup project and use Kestrel profile

Access Token
	Configure token and app info on appsettings AppConfiguration
	Some modules are part of KRFCommon nuget
	On controller set data annotation on request -> [Authorize] for only auth users or [Authorize(Policies.Admin)] (include KRFCommon.Context; for policies) for only admin

Config DB (important)
	LocalDB database
		Add correct connection string for localdb -> [DIR TO PROJECT]\DBFiles\homeDB.mdf
		Set the assembly where project migrations are : MigrationAssembly

	Migrations --> Add-Migration [migration_name] -OutputDir "KRFHomepage.Infrastructure/Migrations" -Project KRFHomepage.Infrastructure
	run update-database or run the project (auto migrations enabled)

	Alternative migrations (not tested)
			dotnet tool install --global dotnet-ef
			go to infrastructure project [KRFHomepage.Infrastructure]
			run:
			dotnet ef  migrations add [migration_name] --context Database.DBContext.[ContextMain] -o KRFHomepage.Infrastructure/Migrations	
Logging
	logs are fully enabled for dev env and warning only for prd
	logs appear on console
	request token and body are logged to the console in dev but not in prd unless appconfig LogExceptionOnPrd is set to true

-->>>>>> RUN The project -> use Kestrel profile to run microservice <<<<<<<<------


Projects 
	App
		Contains all services
		Injection of services made on Injection namespace classes
			-- inject proxies
			-- inject queries
			-- inject commands
			-- inject database context
			
		CQRS commands and querys logic
		Database querys EF
		Constants
		
	Domain
		This project must be free of dependencies
		Static classes and models for CQRS and Database
		
	Infrastructure
		Database Context
			-- main database context file is separated in various partial classes for better separation of processes 
			-- Add function to configure the entity to main file
		Database Migrations
	
	WebApi
		Main application and web service
		Configuration of the app (appconfig.json)
		Configuration of services and call of service injection methods from KRFCommon and App project
		Controllers are setted here (always extend KRFController from KRFCommon)
		