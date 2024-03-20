using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTaxi
{
    internal class Taxi
    {
        // propperties 
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        // method 
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Nama         : {0}", DriverName);
            Console.WriteLine("On Duty             : {0}", OnDuty);
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
            Console.WriteLine();
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}