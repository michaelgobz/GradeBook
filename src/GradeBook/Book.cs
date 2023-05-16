using System.Collections.Generic;
using System
namespace GradeBook 
{
    public class Book 
    {
        private List<double> grades;
        public string name;

        public Book(string name)
        {
           this.grades = new List<double>();
           this.name = name;

        }

        public void AddGrade(double grade){
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var total = 0.0;
            var average = 0.0;
            var max = double.MaxValue;
            var min = double.MinValue;

            foreach(var grade in this.grades)
            {
                total += grade;
                max = Math.Max(grade, max);
                min = Math.Min(grade, min);
            }

            // average

            average = total / this.grades.Count;

            Console.WriteLine($"*******Simple Statistics for {this.name}*******");
            Console.WriteLine($"The total is {total:N2}");
            Console.WriteLine($"The average is {average:N2}");
            Console.WriteLine($"The maximum grade is {max}");
            Console.WriteLine($"The minimum grade is {min}");
        }
    }
}