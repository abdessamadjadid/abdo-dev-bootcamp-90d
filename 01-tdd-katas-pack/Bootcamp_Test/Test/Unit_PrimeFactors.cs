using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp_Test.Test
{
    public class Unit_PrimeFactors
    {

        [Theory]
        [InlineData(60, new int[] { 2,2,3,5 })]
        public void Unit_PrimeFactors_test(int input, int[] expected) 
        {
            //Arrange
            var prime = new PrimeFactors();

            //Act
            var result = prime.PrimeFactor(input);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
