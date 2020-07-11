using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    public class Book
    {
        List<double> grades;
        public string name;


        public Book(string name)
        {
            this.name = name;
            grades= new List<double>();
           
        }


        public void AddGrade(double grade)
        {
            grades.Add(grade);

        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.average = 0.0;
            result.high= double.MinValue;
            result.low = double.MaxValue;
            foreach (var number in grades)
            {
                
                result.high = Math.Max(number, result.high);
                result.low = Math.Min(number, result.low);
                result.average += number;
            }

            result.average /= grades.Count;

            return result;

        }

    }
}
