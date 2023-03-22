namespace assignment_3_and_4;
public class Coordinates
    {
        public double Latitude;
        public double Longitude;

        public Coordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        
        public override string ToString()
        {
            return string.Format("{0}.{1}", Latitude, Longitude);
        }
        
        static double DegreesToRadians(double degrees)
        {
            return (Math.PI / 180) * degrees;
        }
        
        public double DistanceTo(Coordinates other)
        {
            const double EarthEquatorialRadius = 6378.1370; // km
            double lat1 = DegreesToRadians(this.Latitude);
            double lon1 = DegreesToRadians(this.Longitude);
            
            double lat2 = DegreesToRadians(other.Latitude);
            double lon2 = DegreesToRadians(other.Longitude);
            double dlon = lon2 - lon1;
            double dlat = lat2 - lat1;
            double a = Math.Pow(Math.Sin(dlat / 2), 2)
                       + Math.Cos(lat1) * Math.Cos(lat2)
                                        * Math.Pow(Math.Sin(dlon / 2), 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return EarthEquatorialRadius * c;
        }
    }