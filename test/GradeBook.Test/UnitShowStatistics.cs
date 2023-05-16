using Xunit;
using System;

namespace GradeBook.Test;

public class BookTests
{
    [Fact]
    public void TestResultForShowStatistics()
    {
        // arrange 
        Book TestableBook = new Book("TestableBook");
        TestableBook.AddGrade(56.90);
        TestableBook.AddGrade(5.90);
        TestableBook.AddGrade(23.90);
        TestableBook.AddGrade(12.90);
        TestableBook.AddGrade(6.9);
        TestableBook.AddGrade(46.90);

        // act
        TestableBook.ShowStatistics()

        // assert





    }
}