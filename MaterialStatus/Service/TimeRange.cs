using System;

namespace MaterialStatus.Service
{
    public static class TimeRange
    {
        private static int firstHour = 0;
        private static int firstMinute = 0;
        private static int firstSecund = 0;

        private static int lastHour = 23;
        private static int lastMinute = 59;
        private static int lastSecond = 59;


        public static DateTime BeginnTestTime 
        {
            get 
            { 
                return new DateTime(Config.TestDate_year, 
                                    Config.TestDate_month, 
                                    Config.TestDate_day, 
                                    firstHour, 
                                    firstMinute, 
                                    firstSecund); 
            }
            set 
            { 
                new DateTime(Config.TestDate_year,
                             Config.TestDate_month, 
                             Config.TestDate_day,
                             firstHour, 
                             firstMinute, 
                             firstSecund);
            }
        }
        
        public static DateTime EndTestTime 
        {
            get
            {
                return new DateTime(Config.TestDate_year,
                                    Config.TestDate_month,
                                    Config.TestDate_day, 
                                    lastHour, 
                                    lastMinute, 
                                    lastSecond);
            }
            set
            {
                new DateTime(Config.TestDate_year,
                                    Config.TestDate_month,
                                    Config.TestDate_day,
                                    lastHour,
                                    lastMinute,
                                    lastSecond);
            }
        }        
    }
}
