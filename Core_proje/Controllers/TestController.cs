using Microsoft.AspNetCore.Mvc;

namespace Core_project.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
