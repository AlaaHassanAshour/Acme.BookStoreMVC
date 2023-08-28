using Acme.BookStoreMVC.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStoreMVC.Permissions;

public class BookStoreMVCPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var BookStoreMVCGroup = context.AddGroup(BookStoreMVCPermissions.GroupName, L("Permission:BookStoreMVC"));

        var booksPermission = BookStoreMVCGroup.AddPermission(BookStoreMVCPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(BookStoreMVCPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(BookStoreMVCPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(BookStoreMVCPermissions.Books.Delete, L("Permission:Books.Delete"));


        var authorsPermission = BookStoreMVCGroup.AddPermission(
         BookStoreMVCPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(
            BookStoreMVCPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(
            BookStoreMVCPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(
            BookStoreMVCPermissions.Authors.Delete, L("Permission:Authors.Delete"));

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreMVCResource>(name);
    }
}
