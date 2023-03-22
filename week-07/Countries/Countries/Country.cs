namespace Countries;

public class Country
{
    public string Code;     //ISO 3166-1 Country code
    public string Name;

    public int Area;        // km^2
    public int Population;

    public double PopulationDensity     // Persons per km^2
    {
        get
        {
            return Population / Area;
        }
    }

    public Country(string code, string name, int area, int population)
    {
        Code = code;
        Name = name;
        Area = area;
        Population = population;
    }

    public override string ToString()
    {
        return Name;
    }
}