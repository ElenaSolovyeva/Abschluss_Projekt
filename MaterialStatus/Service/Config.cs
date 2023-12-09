﻿using System;
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
        public static string ConnectionStringSWBv2 { get; set; }        
        public static string ConnectionStringSWGv2 { get; set; }

        public static int HalleB_Linie1_id { get; set; }
        public static string HalleB_Linie1_SyloNr { get; set; }

        public static int HalleB_Linie3_id { get; set; }
        public static string HalleB_Linie3_SyloNr { get; set; }

        public static int HalleG_Linie2_id { get; set; }
        public static string HalleG_SyloNr { get; set; }

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
