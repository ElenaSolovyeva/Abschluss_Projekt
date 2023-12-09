using Microsoft.AspNetCore.Mvc;
using MaterialStatus.Models;
using System.Linq;

namespace MaterialStatus.Controllers
{
    public class AdminAreaController : Controller
    {
        public IActionResult AdminArea()
        {
           return View();
        }
    }
}
