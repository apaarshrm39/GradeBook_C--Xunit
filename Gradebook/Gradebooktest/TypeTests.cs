using System;
using Gradebook;
using Xunit;

namespace Gradebooktest
{
    public class TypeTests
    {
        [Fact]
        public void StringBehavesLikeValueTypes()
        {
            string name = "Apaar";
            MakeUpperCase(name);

            Assert.Equal("Apaar",name);
        }

        void MakeUpperCase(string name)
        {
            name.ToUpper();
        }

        //sTRINGS ARE IMMUTABLE
        [Fact]
        public void StringBehavesLikeValueTypes2()
        {
            string name = "Apaar";
            var upper= MakeUpperCase2(name);

            Assert.Equal("APAAR", upper);
        }

        string MakeUpperCase2(string name)
        {
            return name.ToUpper();
        }




        [Fact] //atribute
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("book1");
            var book2 = GetBook("book2");

            Assert.Equal("book1",book1.name);
            Assert.Equal("book2",book2.name);

        }
        [Fact]
        public void TwoVariablesCanReferanceTheSameObjects()
        {
            var book1 = GetBook("book1");
            var book2 = book1;

            //points to the same Reference
            Assert.Same(book1,book2);

            Assert.Equal("book1", book1.name);
            Assert.Equal("book1", book2.name);

        }

        [Fact]
        public void CanSetNameByReferance()
        {
            var book1 = GetBook("book1");
            SetName(book1, "New Name");

            Assert.Equal("New Name",book1.name);


        }

        void SetName(Book book, string name)
        {

            book.name = name;
        }
        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("book1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("book1", book1.name);


        }

        void GetBookSetName(Book book, string name)
        {

            book = new Book(name);
            
        }
        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("book1");
            RefGetBookSetName( ref book1, "New Name");

            Assert.Equal("New Name", book1.name);


        }

        void RefGetBookSetName(ref Book book, string name)
        {

            book = new Book(name);
        }
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}