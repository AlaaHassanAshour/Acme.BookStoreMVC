using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.BookStoreMVC.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BookStoreMVCDbContextFactory : IDesignTimeDbContextFactory<BookStoreMVCDbContext>
{
    public BookStoreMVCDbContext CreateDbContext(string[] args)
    {
        BookStoreMVCEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BookStoreMVCDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new BookStoreMVCDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.BookStoreMVC.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
