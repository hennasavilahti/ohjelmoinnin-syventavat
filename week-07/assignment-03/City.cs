namespace assignment_03;

public class City
{
    private string _name;
    public string Name => _name;

    private Coordinates _location;
    public Coordinates Location => _location;

    public City(string name, Coordinates location)
    {
        _name = name;
        _location = location;
    }

    public override string ToString()
    {
        return $"{Name} @ {Location}";
    }
}