using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace Ubah
{
    public class TripHandler
    {
        //Helper's instance
        private GeoService geoservice = GeoService.GetGeoService();
        public Trip trip = new Trip(); //Trip instance

        //Create instance of the trip.
        //**Note** Just display basic informations of the trip
        public async Task<Trip> CreateTrip(Rider customer, string pickup, string dropoff)
        {
            Dictionary<string, object> pickupLoc = this.CastLoc(loc:pickup);
            Dictionary<string, object> dropoffLoc = this.CastLoc(loc: dropoff);
            // Instantiating a Trip request
            this.trip.Instantiate(customer);
            this.GeneratesID();

            // Verify & Assign Locations
            Task<Dictionary<string, object>> validPickup = this.geoservice.ValidateLocation(location: pickupLoc);
            pickupLoc = await validPickup;

            Task<Dictionary<string, object>> validDropoff = this.geoservice.ValidateLocation(location: dropoffLoc);
            dropoffLoc = await validDropoff;

            this.trip.AssignLocation(pickupLocation: pickupLoc, dropoffLocation: dropoffLoc);


            // Estimate travel distance
            double distance = this.EstimateDistance();
            this.trip.AssignDistance(distance: distance);

            // Estimate fare amount
            double total_fare = this.EstimateFare();
            this.trip.AssignFare(fare: total_fare);

            return this.trip;
        }


        //Begins a trip
        public Trip StartTrip()
        {
            // Searching for nearest active driver
            Driver driver = this.SearchDriver();
            this.trip.AssignDriver(driver);
            this.trip.SetStatus("los geht's");

            return this.trip;
        }


        //Searching for nearest driver
        public Driver SearchDriver()
        {
            List<Driver> ActiveDriversNearby = DataImporter.drivers;
            int randomDriverIndex = DataImporter.rnd.Next(0, ActiveDriversNearby.Count);
            Driver driver = ActiveDriversNearby[randomDriverIndex];
            driver.Decision();
            driver.Status = true;

            if (driver == null) { throw new Exception("No active driver nearby, consider switching vehicle?"); }
            return driver;
        }


        // ID generataaah
        public void GeneratesID()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string IDcode = "";

            for (int i = 0; i < 12; i++)
            {
                IDcode += chars[DataImporter.rnd.Next(chars.Length)];
            }

            this.trip.AssignID(id: IDcode);
        }


        //Distance estimator
        public double EstimateDistance()
        {
            return this.geoservice.CalculateDistance(loc1:this.trip.PickupLocation, loc2:this.trip.DropoffLocation);    
        }


        //Fare estimator
        public double EstimateFare()
        {
            // Base parameters
            const float baseFare = 0.4f;
            const float distanceRate = 0.2f;

            // Perform distance estimation

            // Simulate external factors affecting the fare
            Random rnd = new Random();
            float demand = (float)rnd.NextDouble();
            float weatherCondition = (float)rnd.NextDouble();
            float trafficCongestionRate = (float)rnd.NextDouble();
            float driverDestination = (float)rnd.NextDouble();

            double totalFare = baseFare +
                this.trip.TravelDistance * distanceRate +
                (weatherCondition + trafficCongestionRate + demand) * baseFare * distanceRate * this.trip.TravelDistance +
                driverDestination * distanceRate * baseFare;

            return Math.Round(totalFare, 2);
        }

        public Dictionary<string, object> CastLoc(string loc)
        {
            return new Dictionary<string, object>
            {
                {"q", loc},
                {"format", "json"},
                {"limit", 1},
                {"countrycodes", "VN"}
            };
        }
    }
}



