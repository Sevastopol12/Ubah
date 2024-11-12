using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ubah
{
    /// <summary>
    /// 
    /// A map service object that contains methods that handle API call. Designed to support GeoService class in coordinates operations
    /// 
    /// </summary>
    public class MapService
    {
        private static MapService _instance = null;

        public static MapService getMapService()
        {
            if (_instance == null) {_instance =  new MapService(); }
            return _instance;
        }


        // API elements 
        private const string url = "https://nominatim.openstreetmap.org/search";
        private string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/127.0.0.0 Safari/537.36 OPR/113.0.0.0";


        // Method to interact with the Nominatim API
        private string queryConvert(Dictionary<string, object> parameters)
        {
            string result = "";

            foreach (KeyValuePair<string, object> kvp in parameters)
            {
                result += $"{kvp.Key}={kvp.Value}&";
            }
            return result;
        }


        // Use Jsonelement instead of deserialize method
        private async Task<Dictionary<string, object>> GetElement(string jsonResponse)
        {
            using (JsonDocument doc = JsonDocument.Parse(jsonResponse))
            {
                JsonElement root = doc.RootElement;
                root = root[0];  // Access the first element of the array

                // Gets desired elements
                double lat = Convert.ToDouble(root.GetProperty("lat").GetString());
                double lon = Convert.ToDouble(root.GetProperty("lon").GetString());
                string name = root.GetProperty("display_name").GetString();

                // Copy the boundingbox array to a list of strings
                JsonElement boundingbox_values = root.GetProperty("boundingbox");
                List<string> boundingbox = new List<string>();

                foreach (JsonElement element in boundingbox_values.EnumerateArray())
                {
                    boundingbox.Add(element.GetString());
                }

                // Create the result dictionary with fully extracted values
                Dictionary<string, object> result = new Dictionary<string, object>()
                {
                    {"name", name},
                    {"coordinates", new Location(Latitude: lat, Longitude: lon)},
                    {"boundingbox", boundingbox }
                };
                return result;
            }
        }


        // Geocoding API
        public async Task<Dictionary<string, object>> Nominatim(Dictionary<string, object> location)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", this.userAgent);

                // Convert the dictionary location to query string format
                string locationQuery = this.queryConvert(location);

                // Call API
                HttpResponseMessage response = await client.GetAsync($"{url}?{locationQuery}");

                // Check whether the API responsed
                if (!response.IsSuccessStatusCode) { throw new Exception("Nominatim: Something went wrong"); }

                string jsonResponse = await response.Content.ReadAsStringAsync();

                // Get desired parameters using JsonElement
                Task<Dictionary<string, object>> TaskResult = this.GetElement(jsonResponse: jsonResponse);
                Dictionary<string, object> result = await TaskResult;
                return result;
            }

        }
    }
}
