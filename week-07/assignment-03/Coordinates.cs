namespace assignment_03;
public class Coordinates
{
    private double _latitude;
    private double _longitude;

    public double Latitude
    {
        get => _latitude;
        set
        {
            if (value is >= -90 and < 90)
            {
                _latitude = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    "Latitude",
                    "Must be [-90, 90)"
                );
            }
        }
    }

    public double Longitude
    {
        get => _longitude;
        set
        {
            if (value is >= -180 and < 180)
            {
                _longitude = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    "Longitude",
                    "Must be [-180, 180)"
                );
            }
        }
    }

    public Coordinates(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public override string ToString()
    {
        return $"{Latitude},{Longitude}";
    }
}