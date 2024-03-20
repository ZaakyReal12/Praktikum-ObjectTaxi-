using ObjectTaxi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTaxi_5711
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Taxi 
            Taxi taxi = new Taxi();

            // mengeset nilai properties objek Taxi 
            taxi.DriverName = "Zaaky";
            taxi.OnDuty = true;
            taxi.NumPassenger = 12;

            // memanggil method 
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
