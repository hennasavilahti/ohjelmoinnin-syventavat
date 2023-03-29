using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace assignment_01;

public class Program
{
    public static void Main()
    {
        var items = new List<string> { "Tupu", "Hupu", "Lupu" };
        Console.WriteLine(JoinItems(items, ", ", " and "));
    }
    
    static string JoinItems(List<string> items, string between, string beforeLast)
    {
        var str = string.Join(between, items);
        var replaceIndex = str.LastIndexOf(between);

        if (replaceIndex <= 0)
        {
            return str;
        }

        var result = new StringBuilder(str);
        result.Remove(replaceIndex, between.Length).Insert(replaceIndex, beforeLast);
        return result.ToString();
    }
    
}

