using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialStatus.Models
{
    public class Dispo
    {
        public Int64 Id { get; set; }
        public DateTime Start_time { get; set; } //-
        public DateTime End_time { get; set; } //-
        public Int64 Line_id { get; set; }
        public string Auftragsnr { get; set; }
        public Double Auftragsmenge { get; set; } //-
        public Double Chargenanzahl_soll { get; set; }
        public Double Chargenanzahl_ist { get; set; }
        public Double Chargen_grösse { get; set; } //-
        public Double Chargen_gewicht { get; set; } //-
        public Int64 Rezept_gewicht { get; set; } //-
        public Int64 Rezept_version { get; set; } //-
        public Int64 Ziel { get; set; } //-
        public Int64 Reinigung { get; set; } //-
        public Double Auftrags_gewicht { get; set; } //-
        public Double Restmenge { get; set; } //-
        public Int64 Last_chargen_grösse { get; set; } //-
        public Double Last_chargen_gewicht { get; set; } //-
        public Double Chargenzahl_Rest { get; set; } //-
        public Int64 Status { get; set; } //-
        public Int64 Rt_pack_nr { get; set; } //-
        public Double Auftrags_gewicht_ist { get; set; }
        public String Rz_nr { get; set; } //-
        public Int32 Handstatus { get; set; } //-
        public Int32 Productgruppe { get; set; } //-
        public Int32 Gebinde { get; set; } //-
        public String Bemerkung { get; set; } //-
        public String Lager_Bez { get; set; } //-
        public String Material_Bez { get; set; } //-
        public String Lager_SAP { get; set; } //-
        public Int64 Gebinde_id { get; set; } //-
        public Int64 Farb_id { get; set; } //-
        public String SAP_auftragsnr { get; set; } //-
        public Boolean SAP_verbucht { get; set; } //-

        public Dispo() { }

        public Dispo(string auftragsnr, string Material, Double Charge_soll, 
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

        public Dispo(string auftragsnr, string Material, double Charge_soll, 
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
