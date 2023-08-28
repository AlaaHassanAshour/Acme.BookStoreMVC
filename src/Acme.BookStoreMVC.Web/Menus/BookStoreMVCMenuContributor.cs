using System.Threading.Tasks;
using Acme.BookStoreMVC.Localization;
using Acme.BookStoreMVC.MultiTenancy;
using Acme.BookStoreMVC.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Acme.BookStoreMVC.Web.Menus;

public class BookStoreMVCMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<BookStoreMVCResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                BookStoreMVCMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );
        context.Menu.AddItem(
    new ApplicationMenuItem(
        "BooksStoreMVC",
        l["Menu:BooksStoreMVC"],
        icon: "fa fa-book"
    ).AddItem(
        new ApplicationMenuItem(
            "BooksStoreMVC.Books",
            l["Menu:Books"],
            url: "/Books"
        ).RequirePermissions(BookStoreMVCPermissions.Books.Default)
    ).AddItem( 
        new ApplicationMenuItem(
            "BooksStoreMVC.Authors",
            l["Menu:Authors"],
            url: "/Authors"
        ).RequirePermissions(BookStoreMVCPermissions.Authors.Default)
    )
);

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        return Task.CompletedTask;
    }
}
