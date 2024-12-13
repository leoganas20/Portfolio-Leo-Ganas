using Leo.Projects.Portfolio.Web.Pages.ComponentPageBase;

namespace Leo.Project.Portfolio.Web.Pages;

public class HomeBase : ComponentPageBase
{

    protected async override Task OnInitializedAsync()
    {
        IsVisible = true;

        await Task.Delay(3000);

        IsVisible = false;
    }
}