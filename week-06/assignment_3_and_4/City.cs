namespace assignment_3_and_4;

public class City
{
    public string Name;
    private Coordinates Location;

    public City(string name, Coordinates location)
    {
        Name = name;
        Location = location;
    }

    public override string ToString()
    {
        return string.Format("{0} @ {1}, {2}", Name, Location.Latitude, Location.Longitude);
    } 
}