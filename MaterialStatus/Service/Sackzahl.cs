using System.Collections.Generic;

namespace MaterialStatus.Service
{
    public class Sackzahl
    {
        private List<MaterialStatus.Features.SWB.Models.tbl_dispo> dispoListSWB;
        private List<MaterialStatus.Features.SWG.Models.tbl_dispo> dispoListSWG;
        public string result = "n.A.";

        public Sackzahl(List<MaterialStatus.Features.SWB.Models.tbl_dispo> dispoList) 
        {
            dispoListSWB = dispoList;
        }

        public Sackzahl(List<MaterialStatus.Features.SWG.Models.tbl_dispo> dispoList)
        {
            dispoListSWG = dispoList;
        }

        public string GetSackzahlSWB(string auftragsNr, int lineId)
        {
            foreach (var row in dispoListSWB) 
            {
                if (row.auftragsnr == auftragsNr & row.line_id == 3)
                    result = row.chargenanzahl_ist.ToString();
            }
            
            return result;         
        }

        public string GetSackzahlSWG(string auftragsNr, int lineId)
        {
            foreach (var row in dispoListSWG)
            {
                if (row.auftragsnr == auftragsNr & row.line_id == 3) // line_id == 3 so ist im Projekt Quick_Mix_StatusScreen definiert
                    result = row.chargenanzahl_ist.ToString();
            }

            return result;
        }
    }
}