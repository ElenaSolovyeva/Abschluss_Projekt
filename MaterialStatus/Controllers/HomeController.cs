using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MaterialStatus.Features.SWB.Models;

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

