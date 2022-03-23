using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }
        
        private string OnDutyYN()
        {
            return OnDuty ? "yes" : "no";
        }
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDutyYN());
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Selesai mengantar penumpang", DriverName);
        }
    }
}