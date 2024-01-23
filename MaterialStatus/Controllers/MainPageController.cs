using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using MaterialStatus.Features.SWB.Models;
using MaterialStatus.Features.SWG.Models;
using System;

namespace MaterialStatus.Controllers
{
    public class MainPageController : Controller
    {
        private readonly SwbDbContext contextSWB;
        private readonly SwgDbContext contextSWG;
        
        public MainPageController(SwbDbContext contextSWB, SwgDbContext contextSWG)
        {
            this.contextSWB = contextSWB;
            this.contextSWG = contextSWG;
        }

        public IActionResult MainPage()
        {
            ViewData["DispoB"] = contextSWB.tbl_dispo.ToList();
            ViewData["FarbeBezeichnungB"] = contextSWB.tbl_stueckliste_historie_kopf.ToList();
            ViewData["DispoG"] = contextSWG.tbl_dispo.ToList();
            ViewData["LagerG"] = contextSWG.tbl_lager.ToList();
            ViewData["MaterialG"] = contextSWG.tbl_material.ToList();
            ViewData["EquipementDosierG"] = contextSWG.tbl_equipement_dosier.ToList();

 
            List<String?> rohstoffSilos = new List<string?>();
            foreach (var eqDosierG in ViewData["EquipementDosierG"]
                        as List<MaterialStatus.Features.SWG.Models.tbl_equipement_dosier>)
            {
                foreach (var lagerG in ViewData["LagerG"]
                            as List<MaterialStatus.Features.SWG.Models.tbl_lager>)
                {
                    if (eqDosierG.lager_Id == lagerG.id
                        && lagerG.aktiv == 1 
                        && lagerG.aktiv1 == 1)
                            
                        rohstoffSilos.Add(lagerG.sap_bezeichnung);
                }
            }

            rohstoffSilos.Sort();

            ViewData["RohstoffSilos"] = rohstoffSilos;

            return View();
        }
    }    
}
