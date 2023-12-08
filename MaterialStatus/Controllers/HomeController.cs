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
            ViewData["Data"] = context.Dispos.ToList();
            Dispo item = new Dispo();
            return View();
        }
    }
}

