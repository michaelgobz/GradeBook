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

        List<double> data = new List<double>() 
        {10.1,23.4,34.3,18.9,18.20,90.0,12.90,89.89,89.0,34.89,12.90};

        // load that through a process

        foreach(var element in data)
        {
          GradeBook.AddGrade(element);
        }

        // statistics
        GradeBook.ShowStatistics();

    }
  }
}
