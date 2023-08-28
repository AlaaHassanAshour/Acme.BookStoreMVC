using Acme.BookStoreMVC.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.BookStoreMVC.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BookStoreMVCPageModel : AbpPageModel
{
    protected BookStoreMVCPageModel()
    {
        LocalizationResourceType = typeof(BookStoreMVCResource);
    }
}
