using Microsoft.AspNetCore.Mvc;

namespace myTeam.Components
{
    public class FooterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync ()
        {
            return View("_Footer");
        }
    }
}
