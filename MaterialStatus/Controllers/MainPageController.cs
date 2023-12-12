using Microsoft.AspNetCore.Mvc;
using MaterialStatus.Models;
using System.Linq;

namespace MaterialStatus.Controllers
{
    public class MainPageController : Controller
    {
        private readonly AppDbContext context;
        public MainPageController(AppDbContext context) { this.context = context; }
        public IActionResult MainPage()
        {
            ViewData["DataB"] = context.tbl_dispo.ToList();
            //ViewData["DataG"] = context.DisposG.ToList();

            return View();
        }
    }

    
}
