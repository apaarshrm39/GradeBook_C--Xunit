using System;
using System.Collections.Generic;

namespace Gradebook
{


class Program
{
    static void Main(string[] args)
    {
        var book = new Book("Apaar's Book");
        book.AddGrade(80.9);
        book.AddGrade(99.0);
        book.AddGrade(76.8);

        var stat= book.GetStatistics();
        Console.WriteLine($"the average is {stat.average}");
        Console.WriteLine($"the low is {stat.low}");
        Console.WriteLine($"the high is {stat.high}");

    }
    }
    
}
