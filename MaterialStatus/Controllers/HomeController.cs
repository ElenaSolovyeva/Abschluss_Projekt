using Microsoft.AspNetCore.Mvc;

namespace MaterialStatus.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
