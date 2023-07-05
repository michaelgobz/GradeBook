using System.Collections.Generic;
using System;
namespace GradeBook
{
    public interface IBook
    {
        void AddGrade(double grade);
        void ShowStatistics(Statistics result);
        event GradeAddDelegate GradeAdded;
        string Name { get; }
    }

    public delegate void GradeAddDelegate(object sender, EventArgs args);

    public class NamedObject 
    {
        public string Name
        {
            get;
            set;
        }

    }

    public class Book : NamedObject, IBook
    {
        private List<double> Grades;
        public event GradeAddDelegate GradeAdded;

        private String name;


        public Book(string name)
        {
            this.Grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                Grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"invalid {nameof(grade)}");
            }
        }
        public void ShowAndPrintStatistics(Statistics result)
        {
            foreach (var grade in this.Grades)
            {
                result.Add(grade);
            }

            Console.WriteLine($"For the Book named .... {this.Name}");
            Console.WriteLine($"The total is {result.total:N2}");
            Console.WriteLine($"The average is {result.average:N2}");
            Console.WriteLine($"The maximum grade is {result.maximum}");
            Console.WriteLine($"The minimum grade is {result.minimum}");
            Console.WriteLine($"The letter grade is {result.Letter}");
        }
    }
}