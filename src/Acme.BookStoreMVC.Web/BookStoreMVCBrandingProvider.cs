using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStoreMVC.Web;

[Dependency(ReplaceServices = true)]
public class BookStoreMVCBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BookStoreMVC";
}
