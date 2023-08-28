using Acme.BookStoreMVC.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.BookStoreMVC.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookStoreMVCEntityFrameworkCoreModule),
    typeof(BookStoreMVCApplicationContractsModule)
    )]
public class BookStoreMVCDbMigratorModule : AbpModule
{
}
