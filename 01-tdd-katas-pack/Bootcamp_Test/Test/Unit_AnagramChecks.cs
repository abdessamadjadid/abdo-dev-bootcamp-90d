using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bootcamp_Test.Test
{
    public class Unit_AnagramChecks
    {

        [Theory]
        [InlineData("silent", "listen", true)]
        public void Unit_AnagramChecks_Test(string a, string b, bool expected)
        {
            // Arrange
            var Ana = new AnagramChecks();

            // Act
            var result = AnagramChecks.AnagramCheck(a.ToCharArray(), b.ToCharArray());

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
