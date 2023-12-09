using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialStatus.Models
{
    public class DispoB : Dispo
    {   
        public Int64 Reihenfolge { get; set; } //-
        public Int64 Gebinde_id { get; set; } //-
        public Int64 Farb_id { get; set; } //-
        public String SAP_auftragsnr { get; set; } //-
        public Boolean SAP_verbucht { get; set; } //-

        public DispoB() { }

        public DispoB(string auftragsnr, string Material, Double Charge_soll, 
                     double Charge_ist, Double Auftrag_soll, Double Auftrag_Ist,
                     Int64 Line_ID, Int64 Status)
        {
            Auftragsnr = auftragsnr;
            Material_Bez = Material;
            Chargenanzahl_soll = Charge_soll;
            Chargenanzahl_ist = Charge_ist;
            Auftrags_gewicht = Auftrag_soll;
            Auftrags_gewicht_ist = Auftrag_Ist;
            Line_id = Line_ID;
            this.Status = Status;
        }

        public DispoB(string auftragsnr, string Material, double Charge_soll, 
                     Double Charge_ist, Double Auftrag_soll, Double Auftrag_Ist, 
                     Int64 Line_ID, Int64 Status, Int64 farbid)
        {
            Auftragsnr = auftragsnr;
            Material_Bez = Material;
            Chargenanzahl_soll = Charge_soll;
            Chargenanzahl_ist = Charge_ist;
            Auftrags_gewicht = Auftrag_soll;
            Auftrags_gewicht_ist = Auftrag_Ist;
            Line_id = Line_ID;
            this.Status = Status;
            Farb_id = farbid;
        }

    }
}
