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
            Grades.Add(grade);
        }

        public void AddLetterGrade(char Letter){

        }

        public Statistics ComputeStatistics()
        {
            Statistics result = new Statistics();

            result.maximum = 0.0;
            result.minimum = 0.0;

            foreach(var grade in this.Grades)
            {
                result.total += grade;
                result.maximum = Math.Max(grade, result.maximum);
                result.minimum = Math.Min(grade, result.minimum);
            } 

            // average
            result.average = result.total / this.Grades.Count;
            // compute the letter grade

            switch(result.average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                case var d when d >= 50.0:
                    result.Letter = 'E';
                    break;
                default:
                    result.Letter = 'F';
                    break;
                
            }

            return result;
        }
        
        public void ShowStatistics(Statistics result)
        {
            Console.WriteLine($"*******Simple Statistics for {this.Name}*******");
            Console.WriteLine($"The total is {result.total:N2}");
            Console.WriteLine($"The average is {result.average:N2}");
            Console.WriteLine($"The maximum grade is {result.maximum}");
            Console.WriteLine($"The minimum grade is {result.minimum}");
            Console.WriteLine($"The letter grade is {result.Letter}");
        }
    }
}