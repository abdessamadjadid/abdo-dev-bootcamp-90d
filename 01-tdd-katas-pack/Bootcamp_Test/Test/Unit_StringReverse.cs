namespace Bootcamp_Test.Test
{
    public class Unit_StringReverse
    {
        [Theory]
        [InlineData("ronaldo","odlanor")]
        [InlineData("123","321")]
       
        public void StringReverse_Test(string input, string expected)
        {

            // Arrange
            var sut = new StringReverses();
            var chars = input.ToCharArray();

            // Act
            sut.StringReverse(chars);
            var result = new string(chars);

            // Assert
            Assert.Equal(expected, result);



        }
    }
}
