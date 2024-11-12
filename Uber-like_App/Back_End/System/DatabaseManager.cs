using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ubah
{
    public class DatabaseManager
    {
        //Singleton
        private static DatabaseManager _instance = null;

        public static DatabaseManager GetState()
        {
            if (_instance == null) { _instance = new DatabaseManager(); }
            return _instance;
        }
        //Database source
        private static string basePath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
        public string database = Path.Combine(basePath, "Database", "history.json");
        //Helper
        private JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };


        // Store trip 
        public void StoreTrip(Trip trip) 
        {
            List<TripHistory> tripList = this.GetAllTrips();

            TripHistory newTrip = new TripHistory
            {
                date = trip.Date.ToString(),
                tripID = trip.ID, 
                pickup = trip.PickupAddress,
                dropoff = trip.DropoffAddress,
                fare = trip.FareAmount.ToString(),
                distance = trip.TravelDistance.ToString(),
                riderID = trip.RiderID,
                driverID = trip.DriverID
            };
            tripList.Add(newTrip);

            string jsonString = JsonSerializer.Serialize(tripList, this.options);
            File.WriteAllText(this.database, jsonString);
        }


        //Search for user's trips
        public List<TripHistory> SearchTrip(string UserID)
        {
            List<TripHistory> temp_triplist = this.GetAllTrips();
            List<TripHistory> meine_trips = new List<TripHistory>();

            foreach (TripHistory trip in temp_triplist)
            {
                if (trip.riderID == UserID) { meine_trips.Add(trip); }
            }

            if (meine_trips.Count < 1) { return null; }
            return meine_trips;
        }


        //Get all trips
        public List<TripHistory> GetAllTrips()
        {
            string jsonString = File.ReadAllText(this.database);
            if (string.IsNullOrEmpty(jsonString))
            {
                return new List<TripHistory>();
            }
            List<TripHistory> tripList = JsonSerializer.Deserialize<List<TripHistory>>(jsonString);
                return tripList;
        }
    }
}
