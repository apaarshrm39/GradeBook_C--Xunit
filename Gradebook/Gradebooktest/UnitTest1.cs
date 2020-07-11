using System;
using Xunit;

namespace Gradebooktest
{
    public class UnitTest1
    {
        [Fact] //atribute
        public void Test1()
        {
            // arange
            var x = 5;
            var y = 2;
            var expected = 10;

            //act
            var actual = x * y;

            //assert
            Assert.Equal(expected, actual);
        }
    }
}