using System.Collections.Generic;
using System.Threading.Tasks;

namespace Acme.BookStoreMVC.Web.Pages;

public class IndexModel : BookStoreMVCPageModel
{
    public List<TodoItemDto> TodoItems { get; set; }
    private readonly ITodoAppService _todoAppService;
    public IndexModel(ITodoAppService todoAppService)
    {
        _todoAppService = todoAppService;
    }

    public async Task OnGetAsync()
    {
        TodoItems = await _todoAppService.GetListAsync();
    }
  
}
