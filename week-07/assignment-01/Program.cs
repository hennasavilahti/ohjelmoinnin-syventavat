namespace assignment_01
{
    public class Program
    {
        public static void Main()
        {
            Country badFinland1 = new Country(
                "FI",
                "Finland",
                338_435,
                5_553_000
            );

            Console.WriteLine(badFinland1);
        }
    }
}