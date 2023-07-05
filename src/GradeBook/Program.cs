// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace GradeBook 
{
  class Program 
  {

    static void Main(string[] args) 
    {
        Book GradeBook = new Book("Michael's GradeBook");

        //grab the user input

        Console.WriteLine("Welcome to Our Gradebook Calculator \n");
        Console.WriteLine("......................................... \n");

        while(true) {
          Console.WriteLine("Please Enter a grade of 'q' to quit \n");

          var input = Console.ReadLine();
          
          if (input == "q"){
            break;
          }
          try 
          {
            var grade = double.Parse(input);
            GradeBook.AddGrade(grade);
          } 
          catch(ArgumentException e)
          {
            Console.WriteLine(e.Message);
          }
          catch(NullReferenceException e){
            Console.WriteLine(e.Message);
          }
          
        }

        // statistics
        var stats = GradeBook.ComputeStatistics();
        GradeBook.ShowStatistics(stats);

    }
  }
}
