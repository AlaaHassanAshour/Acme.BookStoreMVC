using Acme.BookStoreMVC.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStoreMVC.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStoreMVCController : AbpControllerBase
{
    protected BookStoreMVCController()
    {
        LocalizationResource = typeof(BookStoreMVCResource);
    }
}
