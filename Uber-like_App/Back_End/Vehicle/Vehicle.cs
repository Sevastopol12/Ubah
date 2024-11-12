using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubah
{
    public class Vehicle
    {
        public string VehicleId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Transmission { get; set; }
        public string Trim { get; set; }
        public string CarPlate { get; set; }

        public Dictionary<string, string> GetDetails()
        {
            return new Dictionary<string, string>
            {
                ["Brand"] = this.Brand,
                ["Model"] = this.Model,
                ["Color"] = this.Color,
                ["Transmission"] = this.Transmission,
                ["Trim"] = this.Trim,
                ["Plate"] = this.CarPlate
            };
        }

    }
}
