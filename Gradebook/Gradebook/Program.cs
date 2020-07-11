using System;
using System.Collections.Generic;
using System.Dynamic;

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


        while (true)
        {
            Console.WriteLine("enter a grade or 'q' to quit");
            var input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }

            try
            {
                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        var stat= book.GetStatistics();
        Console.WriteLine($"the average is {stat.average}");
        Console.WriteLine($"the low is {stat.low}");
        Console.WriteLine($"the high is {stat.high}");
        Console.WriteLine($"The letter grade is {stat.letter}");

    }
    }
    
}
