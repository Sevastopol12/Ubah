using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubah
{
    public class Location
    {

        // This class should encompasses everything that are related to "user's location"
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Location(double Latitude, double Longitude)
        {
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }

    }
}
