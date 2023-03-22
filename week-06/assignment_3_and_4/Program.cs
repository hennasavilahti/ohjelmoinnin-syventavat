namespace assignment_3_and_4
{
    class Program
    {
        static void Main()
        {
            Coordinates stockholm = new Coordinates(59.3294, 18.0686);
            Coordinates london = new Coordinates(51.5072, -0.1275);

            // Console.WriteLine(london.DistanceTo(stockholm) + " kilometers.");

            City helsinki = new City("Helsinki", new Coordinates(60.1708, 24.9375));
            Console.WriteLine(helsinki);
        }
    }
}