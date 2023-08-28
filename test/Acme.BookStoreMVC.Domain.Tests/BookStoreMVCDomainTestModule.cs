using Acme.BookStoreMVC.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.BookStoreMVC;

[DependsOn(
    typeof(BookStoreMVCEntityFrameworkCoreTestModule)
    )]
public class BookStoreMVCDomainTestModule : AbpModule
{

}
