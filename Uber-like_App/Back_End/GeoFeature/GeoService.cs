using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ubah
{
    /// <summary>
    /// A Geography service that handles the operation between coordinates, "Location" object
    /// </summary>
    public class GeoService
    {
        // Singleton instance
        private static GeoService _instance = null;

        // Singleton implementation
        public static GeoService GetGeoService()
        {
            if (_instance == null)
            {
                _instance = new GeoService();
            }
            return _instance;
        }

        // Constants
        private const double A = 6378137.0;  // Semi-major axis (meters)
        private const double F = 1 / 298.257223563;  // Flattening
        private const double B = (1 - F) * A;  // Semi-minor axis
        protected MapService mapService = MapService.getMapService();

        // Method to validate the location
        public async Task<Dictionary<string, object>> ValidateLocation(Dictionary<string, object> location)
        {
            Dictionary<string, object> validLocation = await this.mapService.Nominatim(location);

            if (validLocation == null)
            {
                throw new Exception("Location not found, consider providing more detail, i.e. district, city, etc.");
            }

            return validLocation;
        }

        // Calculate the distance between two locations

        // Helper method to convert degrees to radians
        private double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        public double CalculateDistance(Location loc1, Location loc2)
        {
            // Get coordinates for the two locations
            double pickupLat = DegreesToRadians(loc1.Latitude);
            double pickupLon = DegreesToRadians(loc1.Longitude);
            double dropoffLat = DegreesToRadians(loc2.Latitude);
            double dropoffLon = DegreesToRadians(loc2.Longitude);

            // Longitude's difference
            double L = dropoffLon - pickupLon;

            // Calculate U1 and U2
            double U1 = Math.Atan((1 - F) * Math.Tan(pickupLat));
            double U2 = Math.Atan((1 - F) * Math.Tan(dropoffLat));

            double sinU1 = Math.Sin(U1);
            double cosU1 = Math.Cos(U1);
            double sinU2 = Math.Sin(U2);
            double cosU2 = Math.Cos(U2);

            double lambda = L;
            double sinLambda = 0, cosLambda = 0, sinSigma = 0, cosSigma = 0, sigma = 0, sinAlpha = 0, cos2Alpha = 0, cos2SigmaM = 0, C = 0;
            double lambdaPrev = 0;

            // Iterate until convergence
            for (int i = 0; i < 1000; i++)
            {
                sinLambda = Math.Sin(lambda);
                cosLambda = Math.Cos(lambda);
                sinSigma = Math.Sqrt((cosU2 * sinLambda) * (cosU2 * sinLambda) +
                                    (cosU1 * sinU2 - sinU1 * cosU2 * cosLambda) * (cosU1 * sinU2 - sinU1 * cosU2 * cosLambda));

                if (sinSigma == 0)
                    return 0;  // Co-incident points

                cosSigma = sinU1 * sinU2 + cosU1 * cosU2 * cosLambda;
                sigma = Math.Atan2(sinSigma, cosSigma);
                sinAlpha = cosU1 * cosU2 * sinLambda / sinSigma;
                cos2Alpha = 1 - sinAlpha * sinAlpha;
                cos2SigmaM = cosSigma - 2 * sinU1 * sinU2 / cos2Alpha;
                C = F / 16 * cos2Alpha * (4 + F * (4 - 3 * cos2Alpha));

                lambdaPrev = lambda;
                lambda = L + (1 - C) * F * sinAlpha * (sigma + C * sinSigma * (cos2SigmaM + C * cosSigma * (-1 + 2 * cos2SigmaM * cos2SigmaM)));

                if (Math.Abs(lambda - lambdaPrev) < 1e-12)
                    break;  // Convergence reached
            }

            // Final calculations
            double u2 = cos2Alpha * (A * A - B * B) / (B * B);
            double A_ = 1 + u2 / 16384 * (4096 + u2 * (-768 + u2 * (320 - 175 * u2)));
            double B_ = u2 / 1024 * (256 + u2 * (-128 + u2 * (74 - 47 * u2)));
            double deltaSigma = B_ * sinSigma * (cos2SigmaM + B_ / 4 * (cosSigma * (-1 + 2 * cos2SigmaM * cos2SigmaM) -
                                        B_ / 6 * cos2SigmaM * (-3 + 4 * sinSigma * sinSigma) * (-3 + 4 * cos2SigmaM * cos2SigmaM)));

            double distance = B * A_ * (sigma - deltaSigma);  // Distance in meters

            return Math.Round(distance / 1000, 2);  // Convert to kilometers and round to 2 decimal places
        }
    }
}
    
