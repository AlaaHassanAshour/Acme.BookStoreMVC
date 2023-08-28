using Volo.Abp.Settings;

namespace Acme.BookStoreMVC.Settings;

public class BookStoreMVCSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookStoreMVCSettings.MySetting1));
    }
}
