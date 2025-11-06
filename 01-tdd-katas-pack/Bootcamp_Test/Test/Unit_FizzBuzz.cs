using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Test.Test
{
    public class Unit_FizzBuzz
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void Unit_FizzBuzz_Test(int input, string expected)
        {

            //Arrange
            var fi = new FizzBuzzs();

            //Act
            var result = fi.FizzBuzz(input);

            //Assert
            Assert.Equal(expected, result);


        }

    }
}
