using Xunit;
using System;
using GradeBook;

namespace GradeBook.Test
{
    public delegate string WriteLogDelegate(string message);
    public class TypesTest
    {
        int count = 0;
        [Fact]
        public void TestWriteLogDelegate(){
            WriteLogDelegate logger = LogMessage;
            logger += LogMessage;
            logger += CountLogMessage;

            var result = logger("hello Dear");

            Assert.Equal(3,count);
        }

        public string LogMessage(string message){
            count =+ 1;
            return message;
        }

        public string CountLogMessage(string message){
            count =+ 1;
            return message;

        }

        [Fact]
        public void TestBookType()
        {
            Book book1 = GetBook("book 1");
            Book book2 = GetBook("book 2");
            Book book3 = GetBook("book 3");
            Book book4 = GetBook("book 4");

            Assert.Equal("book 1",book1.Name);
            Assert.Equal("book 2",book2.Name);
            Assert.Equal("book 3",book3.Name);
            Assert.Equal("book 4",book4.Name);

        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            Book book1 = GetBook("book 1");
            Book book2 = book1;

            Assert.Equal("book 1",book1.Name);
            Assert.Equal("book 1",book2.Name);
            Assert.Same(book1, book2);
        }

        [Fact]
        public void IsTheChangedNameVisible()
        {
            // arrange
            Book book5 = new Book("book 5");
            var name = "Michael's GradeBook";

            //act
            SetName(book5, name);

            //assert 
            Assert.Equal(name, book5.Name);
        }

        // utility methods 
        internal Book GetBook(string name)
        {
            return new Book(name);
        }

        private void SetName(Book b, string name)
        {
            b.Name = name;         
        }
    }
}