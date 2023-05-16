using System.Collections.Generic;
using System;
namespace GradeBook 
{
    public class Book 
    {
        private List<double> Grades;
        public string Name;

        public Book(string name)
        {
           this.Grades = new List<double>();
           this.Name = name;

        }

        public void AddGrade(double grade){
            grades.Add(grade);
        }

        public Statistics ComputeStatistics()
        {
            Statistics result = new Statistics();

            result.maximum = double.MaxValue;
            result.minimum = double.MinValue;

            foreach(var grade in this.grades)
            {
                result.total += grade;
                result.maximum = Math.Max(grade, result.maximum);
                result.minimum = Math.Min(grade, result.minimum);
            } 

            // average
            result.average = result.total / this.grades.Count;

            return result;
        }
        
        public void ShowStatistics(Statistics result)
        {
            Console.WriteLine($"*******Simple Statistics for {this.name}*******");
            Console.WriteLine($"The total is {result.total:N2}");
            Console.WriteLine($"The average is {result.average:N2}");
            Console.WriteLine($"The maximum grade is {result.maximum}");
            Console.WriteLine($"The minimum grade is {result.minimum}");
        }
    }
}