using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Ubah
{
    public class System
    {
        //Helper
        private string name = "Das System~";
        private List<object> members = new List<object>();
        private TripHandler triphandler = new TripHandler();
        private DatabaseManager databaseManager = DatabaseManager.GetState();
        private MapService mapService = MapService.getMapService();    

        // UI
        // Cast location 
        public static Dictionary<string, object>CastLoc(string loc)
        {
            return new Dictionary<string, object>
            {
                {"q", loc},
                {"format", "json"},
                {"limit", 1},
                {"countrycodes", "VN"}
            };
        }

        // Show trip information
        public async Task<Trip> ShowTripProperties(Rider customer, Dictionary<string, object> pickup, Dictionary<string, object> dropoff)
        {
            try
            {
                // Initizializing a ride
                return await this.triphandler.CreateTrip(customer, pickup, dropoff);
            }

            catch (Exception ex) {return null; }
        }
        public async Task<bool> StartTrip(Trip trip)
        {
            try
            {
                trip = this.triphandler.StartTrip();
                Console.WriteLine("Searching for nearby driver");

                // Send notification
                this.addMember(trip.Rider);
                this.addMember(trip.Driver);
                this.notify("mail");

                Console.WriteLine("Processing");
                // Progressing
                bool result = await this.Progress(trip);
                // Store trip in database
                this.complete();
                this.StoreTrip(trip: trip);

                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

        private void addMember(object member)
        {
            this.members.Add(member);   
        }
        private void notify(string message)
        {
            foreach (User member in  this.members)
            {
                member.sendNotification(message: message, channel: this.name);
            }
        }


        // Trip progress
        public async Task CancelTrip()
        {
            return;
        }

        private async Task<bool> Progress(Trip trip)
        {
            await Task.Delay(100);
            trip.Driver.StartTrip();

            await Task.Delay(1000);
            if (trip.Driver.TripStatus())
            {
                if (await trip.Driver.CompleteRide())
                { Console.WriteLine("Trip completed"); return true; }
            }
            return false;
        }
        private void complete()
        {
            this.members = new List<object>();
        }



        //Database Section
        public List<TripHistory> ShowTripHistory(string UserID)
        {
            return this.databaseManager.SearchTrip(UserID: UserID);
        }

        //Store trip into database
        public void StoreTrip(Trip trip)
        {
            this.databaseManager.StoreTrip(trip: trip);
        }
        private List<TripHistory> GetAllTrips()
        {   
            return this.databaseManager.GetAllTrips();
        }

    }

}
