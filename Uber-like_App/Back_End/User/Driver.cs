using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ubah
{
    // Driver
    public class Driver : User
    {
        public Vehicle Vehicle { get; set; }
        public bool Status { get; set; }
        public double Rating { get; set; }
        public Random Random { get; } = new Random();

        // Basic methods
        public override Dictionary<string, object> GetInfo()
        {
            Dictionary<string, object> info = new Dictionary<string, object>
            {
                ["UserID"] = this.userID,
                ["Name"] = this.Name,
                ["PhoneNumber"] = this.PhoneNumber,
                ["Vehicle"] = this.Vehicle
            };

            foreach (var detail in Vehicle.GetDetails())
            {
                info[detail.Key] = detail.Value;
            }

            return info;
        }

        public override void sendNotification(object message, object channel)
        {
            Console.WriteLine($"{this.Name} received {message} from {channel}");
        }

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

        // UI/UX
        public bool Decision()
        {
            // Simulate random decision 
            Console.WriteLine($"Driver {this.Name} accepted");
            return true;
        }

        public bool Pickup()
        {
            // Simulate random pickup success
            return Random.NextDouble() <= 0.5;
        }

        public async Task<bool> CompleteRide()
        {
            // Simulate completion time
            await Task.Delay(100);
            return true;
        }

        public void SetStatus(bool available)
        {
            this.Status = available;
        }

        // Marked the trip as completed
        public bool TripStatus()
        {
            return true;
        }

        // Passenger picked up, heading to the destination
        public bool StartTrip()
        {
            return true;
        }
    }
}
