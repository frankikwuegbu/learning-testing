using TimCoreysTestProject.TestEnvironment;

namespace TestEnvironmentTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnSum()
        {
            //Arrange
            var expected = 5;

            //Act
            var actual = new Calculator().Add(3, 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,2,1)]
        public void Subtraction_ShouldReturnDifference(double a, double b, double c)
        {
            //Arrange
            //Act
            var actual = new Calculator().Subtract(a,b);

            //Assert
            Assert.Equal(c, actual);
        }

        [Theory]
        [InlineData(2,3)]
        public void Subtraction_ShouldFail(double a, double b)
        {
            //Arrange
            //Act
            //Assert
            Assert.Throws<Exception>(() =>  new Calculator().Subtract(a,b));
        }

        [Fact]
        public void Multiply_ShouldReturnProduct()
        {
            //Arrange
            var expected = 10;

            //Act
            var actual = new Calculator().Multiply(2, 5);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_ShouldReturnQuotient()
        {
            var expected = 2;

            var actual = new Calculator().Divide(10, 5);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_ShouldReturnZero()
        {
            var expected = 0;

            var actual = new Calculator().Divide(10, 0);

            Assert.Equal(expected, actual);
        }
    }
}
