using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ubah
{

    // Customah
    public class Rider : User
    {
        public string Email { get; set; }

        // Basic methods
        // Receive message from system
        public override void sendNotification(object message, object channel)
        {
            Console.WriteLine($"{this.Name} received {message} from {channel}");
        }

        //Show info
        public override Dictionary<string, object> GetInfo()
        {
            return new Dictionary<string, object>
            {
                ["UserID"] = this.userID,
                ["Name"] = this.Name,
                ["PhoneNumber"] = this.PhoneNumber,
                ["Email"] = this.Email
            };
        }

        //Show trip
        public override string ShowTripHistory()
        {
            List<TripHistory> my_trips = this.system.ShowTripHistory(UserID: this.userID);
            string value = "";
            if (my_trips.Count > 0)
            {
                foreach (TripHistory trip in my_trips)
                {
                    value += trip.Detail();
                }
            }
            return value;
        }

        // Create a trip 
        public async Task<Trip> RequestRide(string pickup, string dropoff)
        {
            // Instantiate ride
            Task<Trip> request = this.system.ShowTripProperties(this, pickup, dropoff);
            Trip trip = await request;

            return trip;
        }

        // This method represent the user's decision whether to proceed with the ride
        public async void StartTrip(Trip trip)
        {
            await system.StartTrip((Trip)trip);
        }

        public async Task CancelTrip()
        {
            this.system.CancelTrip();
            return;
        }
    }
}


