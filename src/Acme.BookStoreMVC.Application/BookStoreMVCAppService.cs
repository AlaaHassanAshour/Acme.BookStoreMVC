using System;
using System.Collections.Generic;
using System.Text;
using Acme.BookStoreMVC.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookStoreMVC;

/* Inherit your application services from this class.
 */
public abstract class BookStoreMVCAppService : ApplicationService
{
    protected BookStoreMVCAppService()
    {
        LocalizationResource = typeof(BookStoreMVCResource);
    }
}
