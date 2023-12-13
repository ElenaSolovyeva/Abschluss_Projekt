using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MaterialStatus.Features.SWB.Models;

namespace MaterialStatus.Controllers
{
    public class HomeController : Controller        
    {
        //private readonly SwgDbContext context;
        //public HomeController(SwgDbContext context) 
        //{
        //    this.context = context;            
        //}
        public IActionResult Index()
        {
           // ViewData["DataB"] = context.tbl_dispo.ToList();
           //// ViewData["DataG"] = context.DisposG.ToList();
    
            return View();
        }
    }
}

