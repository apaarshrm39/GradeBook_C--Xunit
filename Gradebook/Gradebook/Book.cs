using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    public class Book
    {
        List<double> grades;
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }



        public Book(string name)
        {
            this.name = name;
            grades= new List<double>();
           
        }


        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {

                grades.Add(grade);
                if (gradeAdded != null)
                {
                    gradeAdded(this, new EventArgs());
                }

            }

            else
            {
                throw new ArgumentException($"invalid {nameof(grade)}");
            }
        }

        public event GradeAddedDelegate gradeAdded;

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

            switch (result.average)
            {
                case var d when d >= 90.0:
                    result.letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.letter = 'D';
                    break;
                default:
                    result.letter = 'F';
                    break;

            }

            return result;

        }

    }
}
