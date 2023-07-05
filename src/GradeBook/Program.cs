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
            Statistics stats = new Statistics();
            GradeBook.GradeAdded += onGradeAdded;

            //grab the user input
            Console.WriteLine("Welcome to Our Gradebook Calculator \n");
            Console.WriteLine("......................................... \n");

            try 
            {
               AddGrades(GradeBook);
               GradeBook.ShowAndPrintStatistics(stats);
            } 
            catch (NullReferenceException e)
            {
              Console.WriteLine(e.Message);
            }
            
        }

        private static void AddGrades(Book GradeBook)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Please Enter a grade of 'q' to quit \n");

                    var input = Console.ReadLine();
    
                if (input == "q")
                    {
                        break;
                    }
                if (input != null)
                    {
                        try
                        {
                            var grade = double.Parse(input);
                            GradeBook.AddGrade(grade);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (NullReferenceException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }


            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void onGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("A grade was Added");
        }
    }
}
