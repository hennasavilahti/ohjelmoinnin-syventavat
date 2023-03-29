using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace assignment_02;

public class Program
{
    private static void Main()
    {
        var countries = CountryManager.Instance.Countries;
        
        var date25YearsAgo = DateOnly.FromDateTime(DateTime.Now).AddYears(-25);
        var isMemberFor25Years = countries.Where(c => c.Joined <= date25YearsAgo && c.IsCurrentMember).OrderByDescending(c => c.Joined);

        Console.WriteLine("\nCountries that joined the EU 25 or more years ago:");
        foreach (var country in isMemberFor25Years)
        {
            Console.WriteLine($"{country.Name}, joined {country.Joined}");
        }

        var countriesUsingEuro = countries.Where(c => c.Euro.HasValue).OrderByDescending(c => c.Euro);
        
        Console.WriteLine("\nCountries using Euro as currency:");
        foreach (var country in countriesUsingEuro)
        {
            Console.WriteLine($"{country.Name}, since {country.Euro}");
        }

        var joiningDateNotFirstOfJan = countries.Where(c => c.Joined.DayOfYear != 1)
            .OrderByDescending(c => c.Joined);
        
        Console.WriteLine("\nCountries that joined the EU on a date other than January 1st:");
        foreach (var country in joiningDateNotFirstOfJan)
        {
            Console.WriteLine($"{country.Name}, joined {country.Joined}");
        }

        var countriesInSchengen = countries.Count(c => c.Schengen.HasValue);
        Console.WriteLine($"\nNumber of countries in the Schengen Agreement: {countriesInSchengen}");

    }
    
}

