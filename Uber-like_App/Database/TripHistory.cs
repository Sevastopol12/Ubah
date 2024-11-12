using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ubah
{
    public class TripHistory
    {
        public string date {  get; set; }
        public string tripID { get; set; }
        public string pickup { get; set; }
        public string dropoff { get; set; }
        public string fare { get; set; }
        public string distance { get; set; }
        public string riderID { get; set; }
        public string driverID { get; set; }

        public string Detail()
        {
            return $"ID: {tripID}\n" +
                   $"Date: {date}\n" +
                   $"Fare: {fare:F2} $\n" +
                   $"Travel Distance: {distance:F2} km\n" +
                   $"Pickup Address: {pickup ?? "N/A"}\n" +
                   $"Dropoff Address: {dropoff ?? "N/A"}\n\n";
        }
    }

}
