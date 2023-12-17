using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MaterialStatus.Features.SWB.Models;
using MaterialStatus.Features.SWG.Models;

namespace MaterialStatus.Controllers
{
    public class MainPageController : Controller
    {
        private readonly SwbDbContext contextSWB;
        private readonly SwgDbContext contextSWG;
        public MainPageController(SwbDbContext contextSWB, SwgDbContext contextSWG) {
            this.contextSWB = contextSWB;
            this.contextSWG = contextSWG;            
        }
        public IActionResult MainPage()
        {
            ViewData["DispoB"] = contextSWB.tbl_dispo.ToList();
            ViewData["FarbeBezeichnungB"] = contextSWB.tbl_stueckliste_historie_kopf.ToList();
            ViewData["DispoG"] = contextSWG.tbl_dispo.ToList();

            return View();
        }
    }

    
}
