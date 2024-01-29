﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MaterialStatus.Features.Common.Models;
using MaterialStatus.Features.SWB.Models;
using MaterialStatus.Features.SWG.Models;
using System;
using System.Collections.Generic;

namespace MaterialStatus.Controllers
{
    public class HomeController : Controller        
    {
        private readonly SwbDbContext contextSWB;
        private readonly SwgDbContext contextSWG;

        public HomeController(SwbDbContext contextSWB, SwgDbContext contextSWG)
        {
            this.contextSWB = contextSWB;
            this.contextSWG = contextSWG;
        }

        public IActionResult Index()
        {
            ViewData["DispoB"] = contextSWB.tbl_dispo.ToList();
            ViewData["LagerB"] = contextSWB.tbl_lager.ToList();
            ViewData["MaterialB"] = contextSWB.tbl_material.ToList();
            ViewData["FarbeBezeichnungB"] = contextSWB.tbl_stueckliste_historie_kopf.ToList();           
            
            ViewData["DispoG"] = contextSWG.tbl_dispo.ToList();
            ViewData["LagerG"] = contextSWG.tbl_lager.ToList();
            ViewData["MaterialG"] = contextSWG.tbl_material.ToList();

            ViewData["EquipementDosierB"] = contextSWB.tbl_equipement_dosier.ToList();
            List<String?> rohstoffSilosB = new List<String?>();

            foreach (var eqDosier in ViewData["EquipementDosierB"]
                       as List<MaterialStatus.Features.SWB.Models.tbl_equipement_dosier>)
            {
                foreach (var lagerB in ViewData["LagerB"]
                            as List<MaterialStatus.Features.SWB.Models.tbl_lager>)
                {
                    if (eqDosier.lager_Id == lagerB.id
                        && lagerB.aktiv == 1
                        && lagerB.aktiv1 == 1)

                        rohstoffSilosB.Add(lagerB.sap_bezeichnung);
                }
            }

            rohstoffSilosB.Sort();
            ViewData["RohstoffSilosB"] = rohstoffSilosB;

            ViewData["EquipementDosierG"] = contextSWG.tbl_equipement_dosier.ToList();            
            List<String?> rohstoffSilosG = new List<String?>();

            foreach (var eqDosier in ViewData["EquipementDosierG"]
                        as List<MaterialStatus.Features.SWG.Models.tbl_equipement_dosier>)
            {
                foreach (var lagerG in ViewData["LagerG"]
                            as List<MaterialStatus.Features.SWG.Models.tbl_lager>)
                {
                    if (eqDosier.lager_Id == lagerG.id
                        && lagerG.aktiv == 1
                        && lagerG.aktiv1 == 1)

                        rohstoffSilosG.Add(lagerG.sap_bezeichnung);
                }
            }

            rohstoffSilosG.Sort();
            ViewData["RohstoffSilosG"] = rohstoffSilosG;

            

            return View();
        }
    }
}

