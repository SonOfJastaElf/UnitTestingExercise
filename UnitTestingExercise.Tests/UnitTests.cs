using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData (5,5,5,15)]
        [InlineData(6,7,8,21)]
        [InlineData(0,3,5,8)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var testOne = new UnitTestMethods();
            //Act
            var actual = testOne.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7,3,4)]
        [InlineData(6,5,1)]
        [InlineData(7,1,6)]
        [InlineData(7,7,0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var testTwo = new UnitTestMethods();
            //Act
            var actual = testTwo.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8,2,16)]
        [InlineData(4,7,28)]
        [InlineData(6,7,42)]
        [InlineData(0,9,0)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var testThree = new UnitTestMethods();
            //Act
            var actual = testThree.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9,3,3)]
        [InlineData(15,3,5)]
        [InlineData(18,2,9)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var testFour = new UnitTestMethods();
            //Act
            var actual = testFour.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            var expected = "Oh, hi!";
            var instanceOne = new UnitTestMethods();
            //Act
            var actual = instanceOne.ActualOne();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var expected = '@';
            var instanceTwo = new UnitTestMethods();
            //Act
            var actual = instanceTwo.ActualTwo();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
