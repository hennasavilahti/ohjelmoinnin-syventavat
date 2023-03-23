namespace assignment_03;

public class Country
{
    private string _code;       //ISO 3166-1 Country code
    private string _name;
    private double _area;       // km^2
    private int _population;
    private City _capital;

    public City Capital
    {
        get => _capital;
        set
        {
            _capital = value;
        }
    }

    public string Code
    {
        get => _code;
        set
        {
            if (value.Length == 2 && value.All(char.IsUpper))
            {
                _code = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                        "Code",
                        "Value must be 2 letter long and in uppercase.")
                    ;
            }
        }
    }

    public string Name
    {
        get => _name;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _name = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    "Name",
                    "Value must not be empty."
                    );
            }
        }
    }

    public double Area
    {
        get => _area;
        set
        {
            if (value > 0)
            {
                _area = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    "Area",
                    "Value must be over 0.");
            }
        }
    }

    public int Population
    {
        get => _population;
        set
        {
            if (value > 0)
            {
                _population = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    "Population",
                    "Value must be over 0.");
            }
        }
    }

    public double PopulationDensity     // Persons per km^2
    {
        get
        {
            return Population / Area;
        }
    }

    public Country(string code, string name, City capital, double area, int population)
    {
        Code = code;
        Name = name;
        Capital = capital;
        Area = area;
        Population = population;
    }

    public override string ToString()
    {
        return $"{Code}, {Name}, {Capital}";
    }
}