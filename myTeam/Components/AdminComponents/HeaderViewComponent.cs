using Microsoft.AspNetCore.Mvc;

namespace myTeam.Components.AdminComponents
{
    [ViewComponent(Name = "AdminHeader")]
    public class HeaderViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Shared/Components/Admin/Header/_Header.cshtml");
        }
    }
}
