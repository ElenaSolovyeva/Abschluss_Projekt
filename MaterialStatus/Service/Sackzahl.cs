using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialStatus.Features.SWB.Models;
using MaterialStatus.Features.SWG.Models;

namespace MaterialStatus.Service
{
    public class Sackzahl
    {
        private List<MaterialStatus.Features.SWB.Models.tbl_dispo> dispoListSWB;
        private readonly SwbDbContext contextB;
        private readonly SwgDbContext contextG;
        private const int lineId = 3;
        public string result = "n.A.";

        public Sackzahl(List<MaterialStatus.Features.SWB.Models.tbl_dispo> dispoList) 
        {
            dispoListSWB = dispoList;
        }
        public Sackzahl(SwbDbContext context) 
        {
            contextB = context;
        }

        public Sackzahl(SwgDbContext context)
        {
            contextG = context;            
        }

        public string GetSackzahlSWB(string auftragsNr)
        {
            foreach (var row in dispoListSWB) 
            {
                if (row.auftragsnr == auftragsNr & row.line_id == lineId)
                    result = row.chargenanzahl_ist.ToString();
            }
            
            return result;         
        }
    }
}

//public string GetSackzahlSWB(string auftragsNr)
//{
//    foreach (var row in contextB.tbl_dispo)
//    {
//        if (row.auftragsnr == auftragsNr & row.line_id == lineId)
//            result = row.chargenanzahl_ist.ToString();
//    }

//    return result;
//}