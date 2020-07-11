using System;
using Gradebook;
using Xunit;

namespace Gradebooktest
{
    public class BookTests
    {
        [Fact] //atribute
        public void Test2()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var ans= book.GetStatistics();

            //assert
            Assert.Equal(85.6,ans.average,1);
            Assert.Equal(90.5, ans.high,1);
            Assert.Equal(77.3, ans.low,1);
        }
    }
}