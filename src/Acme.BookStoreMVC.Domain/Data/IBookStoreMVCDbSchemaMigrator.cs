using System.Threading.Tasks;

namespace Acme.BookStoreMVC.Data;

public interface IBookStoreMVCDbSchemaMigrator
{
    Task MigrateAsync();
}
