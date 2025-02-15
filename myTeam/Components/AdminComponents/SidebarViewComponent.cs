using Microsoft.AspNetCore.Mvc;

namespace myTeam.Components.AdminComponents
{
    [ViewComponent(Name = "AdminSidebar")]
    public class SidebarViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Views/Shared/Components/Admin/Sidebar/_Sidebar.cshtml");
        }
    }
}
