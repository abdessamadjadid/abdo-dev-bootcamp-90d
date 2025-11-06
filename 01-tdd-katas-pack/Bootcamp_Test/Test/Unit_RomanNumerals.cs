using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Test.Test
{
    
    public class Unit_RomanNumerals
    {

        [Theory]
        [InlineData("1", "I")]
        public void Unit_RomanNumerals_Test(string input, string expected)
        {
            //Arrange
            var rom = new RomanNumerals();
            var number = int.Parse(input);

            //Act
            var result = rom.RomanNumeral(number);

            //Assert
            Assert.Equal(expected, result);
        }


    }
}
