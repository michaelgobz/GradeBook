// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace GradeBook 
{
  class Program 
  {

    static void Main(string[] args) 
    {
        // Grade book as an object
        var result = 0.0;
        var average = 0.0;

        Book GradeBook = new Book("Michael's GradeBook")

        List<double> grades = new List<double>() {10.1,23.4,34.3,18.9,18.20};

        GradeBook.AddGrade(10.1);
        GradeBook.AddGrade(90.1);
        GradeBook.AddGrade(78.1);
        GradeBook.AddGrade(67.1);

        foreach(double grade in grades)
        {
            result += grade;

        }

        average = result / grades.Count;
        if(args.Length > 0) 
        {
            Console.WriteLine($"Welcome to , {GradeBook.name} !");
        }
        else
        {
            Console.WriteLine("hello, Stranger!");
            Console.WriteLine($"Sum of Grades is equal to {result:N2} !");
            Console.WriteLine($"Average of the Grades is {average:N2} !");
        }
    }
  }
}
