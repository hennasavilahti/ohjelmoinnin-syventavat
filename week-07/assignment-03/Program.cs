namespace assignment_03
{
    public class Program
    {
        public static void Main()
        {
            Country[] countriesArray = new Country[5]
            {
                new("FI", "Finland", new City("Helsinki", new Coordinates(60.1708, 24.9375)), 338_435, 5_553_000),
                new("SE", "Sweden", new City("Stockholm", new Coordinates(59.3294, 18.0686)), 438_574, 10_481_937),
                new("GB", "Great Britain", new City("London", new Coordinates(51.5072, -0.1275)), 248_528, 60_800_000),
                new("IT", "Italy", new City("Rome", new Coordinates(41.9, 12.5)), 302_073, 58_983_000),
                new("FR", "France", new City("Paris", new Coordinates(48.8567, 2.3508)), 632_833, 67_897_000)
            };
            
            Array.ForEach(countriesArray, Console.WriteLine);
        }
        
    }
}