using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Acme.BookStoreMVC;

public class BookStoreMVCWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<BookStoreMVCWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
