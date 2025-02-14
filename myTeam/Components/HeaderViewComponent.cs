using Microsoft.AspNetCore.Mvc;

namespace myTeam.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("_Header");
        }
    }
}
