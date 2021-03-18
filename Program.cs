using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            taxi taxi = new taxi();

            taxi.DriverName = "Jono";
            taxi.OnDuty = false;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
