using System;
using System.ComponentModel;

namespace TestaTullen
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Vikt på fordon
            int fordonvikt = 500;
            Console.WriteLine(CheckWeightOfvehicle(fordonvikt));

            //Vilken dag i veckan är det i veckan
            string dayyinweek = "monday";
            Console.WriteLine(WhatDayIsIt(dayyinweek));

            //Kolla vilken typ av fordon det är
            string vehicletype = "motorbike";
            Console.WriteLine(WhatTypeOfVehicle(vehicletype,fordonvikt));

        }
        public static double CheckWeightOfvehicle(int vikt)
        {
            //Vi tar reda på fordonets totala vikt.
            if (vikt >= 1000)
            {
                return 1000;
            }
            else
            {
                return 500;
            }
        }

        public static bool WhatDayIsIt(string dayname)
        {
            if (dayname == "saturday" || dayname == "sunday")
            {
                return false;
            }
            else
            {
                return true;
            }
            // Dagarna i veckan!!!
            //string monday = "monday";
            //string tuesday = "tuesday";
            //string wednesday = "wednesday";
            //string thursday = "thursday";
            //string friday = "friday";
            //string saturday = "saturday";
            //string sunday = "sunday";

        }

        public static double WhatTypeOfVehicle(string vehicletype, int fordonsvikt)
        {
            //Vi tittar på vilken typ av fordon det är och justerar priset efter det.
            if (vehicletype == "car")
            {
                return CheckWeightOfvehicle(fordonsvikt);

            }
            else if (vehicletype == "lastbil")
            {
                return 2000;
            }
            else
            {
                return (CheckWeightOfvehicle(fordonsvikt))*0.7;
            }
        }
    }
}
