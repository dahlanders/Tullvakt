using System;
using System.ComponentModel;

namespace TestaTullen
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ställer in klockan
            var passering = DateTime.Parse("12:00");
            var min = DateTime.Parse("06:00");
            var max = DateTime.Parse("18:00");

            // Vikt på fordon
            int fordonvikt = 1000;

            //Vilken dag i veckan är det i veckan
            string dayyinweek = "sunday";

            //Kolla vilken typ av fordon det är
            //du kan välja på "car", "truck" , "motorbike" and "miljofordon"
            string vehicletype = "miljofordon";

            var test2 = Hello(dayyinweek, vehicletype, fordonvikt, passering, min, max);
           
            Console.WriteLine($"Du kör fordonstyp {vehicletype}på en {dayyinweek} och betalar därför{test2} rubel");
            
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
            else if (vehicletype == "truck")
            {
                return 2000;
            }
            else if ( vehicletype == "miljofordon")
            {
                return 0;
            }
            else
            {
                return (CheckWeightOfvehicle(fordonsvikt)) * 0.7;
            }
        }

        public static double Hello(string dayyinweek, string vehicletype, int fordonvikt, DateTime passering, DateTime min, DateTime max)
        {//Jag kollar vilken veckodag det är och hur mycket de skall betala.
            var getday = WhatDayIsIt(dayyinweek);
            int montofri = getday ? 1 : 0;
            Console.WriteLine(montofri);

            if (montofri == 1 && passering >= min && passering <= max)
            {
                var summafordonochvikt = (WhatTypeOfVehicle(vehicletype, fordonvikt));
                return summafordonochvikt;
            }
            else if (montofri == 1 && passering <= min || passering >=max)
            {
                var summafordonochvikt = (WhatTypeOfVehicle(vehicletype, fordonvikt));
                return summafordonochvikt*0.5;
            }
            else if (montofri == 0)
            {

                var summafordonochvikt = (WhatTypeOfVehicle(vehicletype, fordonvikt));
                return summafordonochvikt * 2;
            }
            else if (vehicletype == "miljofordon")
            {
                return 0;
            }
            else
            {
                return 10000000000000000;
            }
        }
        
    }
}

