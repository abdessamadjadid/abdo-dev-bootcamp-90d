using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Test.Test
{
    public class Unit_Palindrome
    {
        [Theory]
        [InlineData("madam",true)]
        [InlineData("hello", false)]
        public void Unit_Palindrome_Test(string input, bool expected) 
        {
            //Arrange
            var pal = new Palindrome();

            //Act
            var result = pal.IsPalindrome(input);

            // Assert
            Assert.Equal(expected, result);


        }

    }
}
