using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Ubah
{
    public static class FormUser
    {
        public static Rider user;
        public static Trip meineTrip;
    }

    public static class DataImporter
    {
        public static List<Driver> drivers = new List<Driver>();
        public static List<Rider> riders = new List<Rider>();
        public static List<Vehicle> vehicles = new List<Vehicle>();
        public static Random rnd = new Random();

        public static async Task Import()
        {

            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory);
            string basePath = directoryInfo.Parent.Parent.Parent.FullName;

            string vehicleFilePath = Path.Combine(basePath, "Dataset", "vehicles.json");
            string customerFilePath = Path.Combine(basePath, "Dataset", "customers.json");
            string driverFilePath = Path.Combine(basePath, "Dataset", "drivers.json");



            // Load Vehicles
            string vehiclesJson = File.ReadAllText(vehicleFilePath);
            Dictionary<string, Dictionary<string, object>> vehiclesData = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, object>>>(vehiclesJson);

            foreach (KeyValuePair<string, Dictionary<string, object>> vehicleEntry in vehiclesData)
            {
                vehicles.Add(
                    new Vehicle {
                    VehicleId = vehicleEntry.Value["vehicle_id"].ToString(),
                    Brand = vehicleEntry.Value["brand"].ToString(),
                    Model = vehicleEntry.Value["model"].ToString(),
                    Color = vehicleEntry.Value["color"].ToString(),
                    Transmission = vehicleEntry.Value["transmission"].ToString(),
                    Trim = vehicleEntry.Value["trim"].ToString(),
                    CarPlate = vehicleEntry.Value["car_plate"].ToString()
                    }) ;
            } 

            // Load Customers
            string customersJson = File.ReadAllText(customerFilePath);
            Dictionary<string, Dictionary<string, object>> customersData = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, object>>>(customersJson);

            foreach (KeyValuePair<string, Dictionary<string, object>> customerEntry in customersData)
            {
                riders.Add(
                    new Rider {
                    userID =  customerEntry.Value["userID"].ToString(),
                    password = customerEntry.Value["password"].ToString(),
                    Name = customerEntry.Value["name"].ToString(),
                    PhoneNumber = customerEntry.Value["phoneNumber"].ToString(),
                    Email = customerEntry.Value["email"].ToString(),
                    });
            }

            // Load Drivers
            string driversJson = File.ReadAllText(driverFilePath);
            Dictionary<string, Dictionary<string, object>> driversData = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, object>>>(driversJson);
            // Vehicle index
            int idx = 0;

            foreach (KeyValuePair<string, Dictionary<string, object>> driverEntry in driversData)
            {
                drivers.Add(
                    new Driver
                    {
                        userID = driverEntry.Value["userID"].ToString(),
                        Name = driverEntry.Value["name"].ToString(),
                        password = driverEntry.Value["password"].ToString(),
                        PhoneNumber = driverEntry.Value["phoneNumber"].ToString(),
                        Vehicle = vehicles[idx],
                        Status = Convert.ToBoolean(driverEntry.Value["status"].ToString()),
                        Rating = Convert.ToDouble(driverEntry.Value["rating"].ToString())
                    });

                idx ++;
            }

        }

        public static Rider login(string userID, string password)
        {
            foreach(Rider rider in riders)
            {
                if (((string)userID == (string)rider.userID) & 
                    ((string)password == (string)rider.password))
                {
                    return rider;
                }
            }
            return null;
        }
    }
}
