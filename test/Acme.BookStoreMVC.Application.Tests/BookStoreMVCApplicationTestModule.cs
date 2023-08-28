using Volo.Abp.Modularity;

namespace Acme.BookStoreMVC;

[DependsOn(
    typeof(BookStoreMVCApplicationModule),
    typeof(BookStoreMVCDomainTestModule)
    )]
public class BookStoreMVCApplicationTestModule : AbpModule
{

}
