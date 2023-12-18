using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialStatus.Service
{
    public class Config
    {
        public static string Version { get; set; }

        public static string ConnectionStringTest { get; set; }
        public static string ConnectionStringSWB { get; set; }        
        public static string ConnectionStringSWG { get; set; }

        public static int Edelputz1500_LineId { get; set; }
        public static int Edelputz2000_LineId { get; set; }
        public static int GrundPutz_LinId { get; set; }

        public static int FirstSyloId_SWG { get; set; }
        public static int LastSyloId_SWG { get; set; }

        public static int TestDate_year { get; set; }
        public static int TestDate_month { get; set; }
        public static int TestDate_day { get; set; }

        public static string CompanyName { get; set; }
        public static string CompanyPhone { get; set; }
        public static string CompanyPhoneShort { get; set; }
        public static string CompanyFax { get; set; }
        public static string CompanyFaxShort { get; set; }
        public static string CompanyEmail { get; set; }
        public static string CompanyStreet { get; set; }
        public static string CompanyCity { get; set; }
        public static string CompanyWebSite { get; set; }
        public static string CompanyWebSiteShort { get; set; }
        public static string CompanyGoogleMapLink { get; set; }
    }
}
