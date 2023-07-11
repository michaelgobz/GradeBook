using System.Collections.Generic;
using System;
namespace GradeBook
{
    public interface IBook
    {
        void AddGrade(double grade);
        void ShowAndPrintStatistics(Statistics result);
        event GradeAddDelegate GradeAdded;
        string Name { get; }
    }

    public delegate void GradeAddDelegate(object sender, EventArgs args);


    public class Book : IBook
    {
        private List<double> Grades;
        public event GradeAddDelegate GradeAdded;

        public String Name {
            get;
        }


        public Book(string name)
        {
            this.Grades = new List<double>();
            this.Name = name;
        }

        private GradeAddDelegate EventArgs()
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                using(var writer = File.AppendText($"{Name}.txt"))
                {
                    writer.WriteLine(grade);
                }
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
            using(var reader = File.OpenText($"{Name}.txt")){
                string? line = reader.ReadLine();
                while(line != null){
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }

            // write the statics to file
            using(var writer = File.AppendText($"{Name}-stats.txt"))
            {
                writer.WriteLine($"| ...............................................|");
                writer.WriteLine($"| For the Book named .... | {this.Name}  |");
                writer.WriteLine($"| The Total is            | {result.total:N2}             |");
                writer.WriteLine($"| The Average is          | {result.Average:N2}                |");
                writer.WriteLine($"| The Maximum grade is    | {result.maximum}                  |");
                writer.WriteLine($"| The Minimum grade is    | {result.minimum}                    |");
                writer.WriteLine($"| The Letter grade is     | {result.Letter}                    |");
                writer.WriteLine($"| The Number of Person is | {result.Count}                   |");
                writer.WriteLine($"| ...............................................| \n");
            }

                Console.WriteLine($"| ...............................................|");
                Console.WriteLine($"| For the Book named .... | {this.Name}  |");
                Console.WriteLine($"| The Total is            | {result.total:N2}             |");
                Console.WriteLine($"| The Average is          | {result.Average:N2}                |");
                Console.WriteLine($"| The Maximum grade is    | {result.maximum}                  |");
                Console.WriteLine($"| The Minimum grade is    | {result.minimum}                    |");
                Console.WriteLine($"| The Letter grade is     | {result.Letter}                    |");
                Console.WriteLine($"| The Number of Person is | {result.Count}                   |");
                Console.WriteLine($"| ...............................................| \n");
        }
    }
}