using Microsoft.AspNetCore.Mvc;
using MaterialStatus.Models;
using System.Collections.Generic;

namespace MaterialStatus.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Dispo> Edelputz2000 = new List<Dispo>();
            List<Dispo> Edelputz1500 = new List<Dispo>();
            List<Dispo> Grundputz = new List<Dispo>();
            //List<Füllstand> Füllstaende = new List<Füllstand>();


            return View();
        }
    }
}

