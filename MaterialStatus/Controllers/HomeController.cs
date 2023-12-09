using Microsoft.AspNetCore.Mvc;
using MaterialStatus.Models;
using System.Collections.Generic;
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
            ViewData["DataB"] = context.DisposB.ToList();
            ViewData["DataG"] = context.DisposG.ToList();
            //DispoB item = new DispoB();

            
            return View();
        }
    }
}

