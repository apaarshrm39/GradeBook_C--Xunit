using System;
using Gradebook;
using Xunit;

namespace Gradebooktest
{
    public delegate string Logmessage(string log);
    public class TypeTests
    {
        [Fact]
        public void testdelegate()
        {
            Logmessage log;
            //log= new Logmessage(message);

            log = message;

            var result = log("hello");
            Assert.Equal("hello",result);
        }

        string message(string message)
        {
            return message;
        }

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

            Assert.Equal("book1",book1.Name);
            Assert.Equal("book2",book2.Name);

        }
        [Fact]
        public void TwoVariablesCanReferanceTheSameObjects()
        {
            var book1 = GetBook("book1");
            var book2 = book1;

            //points to the same Reference
            Assert.Same(book1,book2);

            Assert.Equal("book1", book1.Name);
            Assert.Equal("book1", book2.Name);

        }

        [Fact]
        public void CanSetNameByReferance()
        {
            var book1 = GetBook("book1");
            SetName(book1, "New Name");

            Assert.Equal("New Name",book1.Name);


        }

        void SetName(Book book, string name)
        {

            book.Name = name;
        }
        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("book1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("book1", book1.Name);


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

            Assert.Equal("New Name", book1.Name);


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