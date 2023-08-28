using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStoreMVC.Data;

/* This is used if database provider does't define
 * IBookStoreMVCDbSchemaMigrator implementation.
 */
public class NullBookStoreMVCDbSchemaMigrator : IBookStoreMVCDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
