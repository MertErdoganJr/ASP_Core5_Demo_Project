using Microsoft.AspNetCore.Mvc;

namespace Core_project.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
