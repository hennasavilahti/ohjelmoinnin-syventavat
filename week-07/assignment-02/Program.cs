namespace assignment_02
{
    public class Program
    {
        public static void Main()
        {
            Country[] countriesArray = new Country[5]
            {
                new("FI", "Finland", 338_435, 5_553_000),
                new("SE", "Sweden", 438_574, 10_481_937),
                new("GB", "Great Britain", 248_528, 60_800_000),
                new("IT", "Italy", 302_073, 58_983_000),
                new("FR", "France", 632_833, 67_897_000)
            };
            
            Array.ForEach(countriesArray, Console.WriteLine);
            Console.WriteLine("Length of the array: " + countriesArray.Length);
            Console.WriteLine("Let's try to put a new country to index 5: ");
            countriesArray[5] = new Country("EE", "Estonia", 45227, 1331824);
        }
        
    }
}