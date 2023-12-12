using Microsoft.AspNetCore.Mvc;
using MaterialStatus.Models;
using System.Linq;

namespace MaterialStatus.Controllers
{
    public class HomeController : Controller        
    {
        private readonly AppDbContext context;
        public HomeController(AppDbContext context) 
        {
            this.context = context;            
        }
        public IActionResult Index()
        {
            ViewData["DataB"] = context.tbl_dispo.ToList();
           // ViewData["DataG"] = context.DisposG.ToList();
    
            return View();
        }
    }
}

