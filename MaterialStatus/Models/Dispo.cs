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
        public Int64 Rezept_id { get; set; } //-
        public Int64 Rezept_version_id { get; set; } //-
        public Int64 Ziel { get; set; } //-
        public Int64 Reinigung { get; set; } //-
        public Double Auftrags_gewicht { get; set; } //-
        public Double Restmenge { get; set; } //-
        
        //public Int64 Last_chargen_grösse { get; set; } //-
        //public Double Last_chargen_gewicht { get; set; } //-
        //public Double Chargenzahl_Rest { get; set; } //-

        public Int64 Status { get; set; } //-
        public Int64 Rt_pack_nr { get; set; } //-
        public Double Auftrags_gewicht_ist { get; set; }
        public String Rz_nr { get; set; } //-
        public Int32 Handstatus { get; set; } //-
        public Int32 Produktgruppe { get; set; } //-
        public Int32 Gebinde { get; set; } //-
        public String Bemerkung { get; set; } //-
        public String Lager_Bez { get; set; } //-
        public String Material_Bez { get; set; } //-
        public String Material_SAP { get; set; } //-
    }
}
