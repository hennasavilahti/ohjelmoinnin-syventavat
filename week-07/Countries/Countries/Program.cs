namespace Countries
{
    public class Program
    {
        public static void Main()
        {
            Country finland = new Country(
                "FI",
                "Finland",
                338_435,
                5_553_000
                );

            Console.WriteLine(finland);
            Console.WriteLine($"Area: {finland.Area} sq. km");
            Console.WriteLine($"Population: {finland.Population}");
            Console.WriteLine($"Population Density: {finland.PopulationDensity} persons / sq. km");
        }
    }
}