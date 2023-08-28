using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.BookStoreMVC.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStoreMVC.EntityFrameworkCore;

public class EntityFrameworkCoreBookStoreMVCDbSchemaMigrator
    : IBookStoreMVCDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBookStoreMVCDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BookStoreMVCDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BookStoreMVCDbContext>()
            .Database
            .MigrateAsync();
    }
}
