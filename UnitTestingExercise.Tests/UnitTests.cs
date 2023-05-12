using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-2, 3, 5, 6)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(0, 0, 0)]
        [InlineData(-2, -3, 1)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(0, 0, 0)]
        [InlineData(-2, 3, -6)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(0, 1, 0)]
        [InlineData(15, 3, 5)]
        public void DivideTest(int dividend, int divisor, int expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Divide(dividend, divisor);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideByZeroThrowsException()
        {
            //Arrange
            var calculator = new Calculator();

            //Act & Assert
            Assert.Throws<ArgumentException>(() => calculator.Divide(10, 0));
        }
    }
}
