using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;


namespace Ubah
{
    public abstract class User
    {
        protected System system = new System(); 
        private List<Trip> rideHistory = new List<Trip>();

        //Base properties
        public string userID { get; set; }
        public string password { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        // Basic methods to manage a User object
        public abstract Dictionary<string, object> GetInfo(); // Show user's info
        public abstract void sendNotification(object message, object channel); // Send a notification to the user
        public abstract string ShowTripHistory(); // Show history
    }
}