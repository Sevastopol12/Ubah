using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;



namespace Ubah
{
    public class Trip
    {
        public DateTime Date { get; private set; }
        public string ID { get; private set; }
        public Rider Rider { get; set; }
        public Driver Driver { get; set; }

        public string RiderID { get; private set; }
        public string DriverID { get; private set; }

        // Destination details
        public Location PickupLocation { get; private set; }
        public Location DropoffLocation { get; private set; }
        public string PickupAddress { get; private set; }
        public string DropoffAddress { get; private set; }


        public double TravelDistance { get; private set; }
        public double FareAmount { get; private set; }
        public string Status { get; private set; }
        public Vehicle vehicle { get; set; }

        public Trip()
        {
            this.Date = DateTime.Today;
        }

        public Dictionary<string, string> Detail()
        {
            return new Dictionary<string, string>
            {
                ["PickupAddress"] = this.PickupAddress,
                ["DropoffAddress"] = this.DropoffAddress,
                ["TravelDistance"] = this.TravelDistance.ToString(),
                ["FareAmount"] = this.FareAmount.ToString(),
            };
        }

        public Trip Instantiate(Rider rider)
        {
            this.Rider = rider;
            this.RiderID = rider.userID;
            return this;
        }

        public Trip AssignID(string id)
        {
            this.ID = id;
            return this;
        }


        // Updating trip status
        public Trip AssignDriver(Driver driver)
        {
            this.Driver = driver;
            this.DriverID = driver.userID;
            this.vehicle = driver.Vehicle;
            return this;
        }

        public Trip AssignLocation(Dictionary<string, object> pickupLocation, Dictionary<string, object> dropoffLocation)
        {
            this.PickupLocation = (Location)pickupLocation["coordinates"];
            this.DropoffLocation = (Location)dropoffLocation["coordinates"];
            this.PickupAddress = (string)pickupLocation["name"];
            this.DropoffAddress = (string)dropoffLocation["name"];
            return this;
        }

        public Trip SetStatus(string status)
        {
            this.Status = status;
            return this;
        }

        public Trip AssignDistance(double distance)
        {
            this.TravelDistance = distance;
            return this;
        }

        public Trip AssignFare(double fare)
        {
            this.FareAmount = fare;
            return this;
        }
    }
}
