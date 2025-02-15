using Microsoft.AspNetCore.Mvc;

namespace myTeam.Components.AdminComponents
{
    [ViewComponent(Name = "AdminEmailNavigationPanel")]
    public class EmailNavigationPanelViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Shared/Components/Admin/EmailNavigationPanel/_EmailNavigationPanel.cshtml");
        }
    }
}
