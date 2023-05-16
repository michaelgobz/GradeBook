using Xunit;
using System;

namespace GradeBook.Test
{
    public class TypesTest
    {
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
            SetName(boo5, name);

            //assert 
            Assert.Equal(name, book5.Name);
        }

        // utility methods 
        internal Book GetBook(string name)
        {
            return new Book(name);
        }

        internal private void SetName(Book b, string name)
        {
            b.Name = name;         
        }
    }
}