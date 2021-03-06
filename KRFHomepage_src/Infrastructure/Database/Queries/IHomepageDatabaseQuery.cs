﻿namespace KRFHomepage.Infrastructure.Database.Queries
{
    using System;
    using System.Threading.Tasks;

    using KRFHomepage.Domain.Database.Homepage;

    public interface IHomepageDatabaseQuery : IDisposable
    {
        Task<HomePageData> GetHomePageDataAsync(string langCode);
    }
}
