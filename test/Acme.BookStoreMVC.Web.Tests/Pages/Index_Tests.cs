using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.BookStoreMVC.Pages;

public class Index_Tests : BookStoreMVCWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
