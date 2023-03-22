namespace assignment_2
{
    class Program
    {
        static void Main()
        {
            Coordinates helsinki = new Coordinates()
            {
                Latitude = 60.1708,
                Longitude = 24.9375
            };
            Coordinates stockholm = new Coordinates()
            {
                Latitude = 59.3294,
                Longitude = 18.0686
            };
            Coordinates london = new Coordinates()
            {
                Latitude = 51.5072,
                Longitude = -0.1275
            };

            Console.WriteLine(london.DistanceTo(stockholm) + " kilometers.");

        }
    }
}