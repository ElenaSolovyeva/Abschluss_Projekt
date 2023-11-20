using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialStatus.Models
{
    public class Dispo
    {
        public string Auftragsnummer { get; set; }
        public string Material_Bez { get; set; }
        public double chargenanzahl_soll { get; set; }
        public double chargenanzahl_ist { get; set; }
        public double auftrags_gewicht { get; set; }
        public double auftrags_gewicht_ist { get; set; }
        public long line_id { get; set; }
        public long status { get; set; }
        public int Chargenzahl { get; set; }
        public int FarbId { get; set; }

        public Dispo(string auftragsnr, string Material, double Charge_soll, double Charge_ist, double Auftrag_soll, double Auftrag_Ist, long Line_ID, long Status)
        {
            Auftragsnummer = auftragsnr;
            Material_Bez = Material;
            chargenanzahl_soll = Charge_soll;
            chargenanzahl_ist = Charge_ist;
            auftrags_gewicht = Auftrag_soll;
            auftrags_gewicht_ist = Auftrag_Ist;
            line_id = Line_ID;
            status = Status;
        }

        public Dispo(string auftragsnr, string Material, double Charge_soll, double Charge_ist, double Auftrag_soll, double Auftrag_Ist, long Line_ID, long Status, int farbid)
        {
            Auftragsnummer = auftragsnr;
            Material_Bez = Material;
            chargenanzahl_soll = Charge_soll;
            chargenanzahl_ist = Charge_ist;
            auftrags_gewicht = Auftrag_soll;
            auftrags_gewicht_ist = Auftrag_Ist;
            line_id = Line_ID;
            status = Status;
            FarbId = farbid;
        }

    }
}
