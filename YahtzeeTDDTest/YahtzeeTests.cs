using System;
using System.Collections.Generic;
using Xunit;
using YahtzeeTDD;

namespace YahtzeeTDDTest
{
    public class YahtzeeTests
    {
        [Theory]
        [InlineData(new[] { 1, 1, 1, 1, 1 }, 1, 5)]
        [InlineData(new[] { 1, 1, 1, 1, 2 }, 1, 4)]
        [InlineData(new[] { 2, 2, 2, 2, 2 }, 1, 0)]
        [InlineData(new[] { 2, 2, 2, 2, 2 }, 2, 10)]
        [InlineData(new[] { 1, 1, 1, 1, 2 }, 2, 2)]
        [InlineData(new[] { 2, 2, 2, 2, 1 }, 2, 8)]
        [InlineData(new[] { 3, 3, 3, 2, 1 }, 3, 9)]
        [InlineData(new[] { 2, 4, 4, 2, 1 }, 4, 8)]
        [InlineData(new[] { 6, 2, 6, 2, 6 }, 6, 18)]
        public void SameNumberCombinations_ReturnSumOfSaidNumber(int[] dice, int number, int expectedResult)
        {
            //Arrange
            PointsCalculator pointsCalculator = new PointsCalculator();
            //Act
            int result = pointsCalculator.GetNumbers(dice,number);
            //Assert
            Assert.Equal(expectedResult,result);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 1, 1, 1 }, 5)]
        [InlineData(new[] { 1, 3, 6, 1, 2 }, 13)]
        public void Chance_ReturnSumOfNumbers(int[] dice, int expectedResult)
        {
            //Arrange
            PointsCalculator pointsCalculator = new PointsCalculator();
            //Act
            int result = pointsCalculator.GetSum(dice);
            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 1, 5, 3 }, 11)]
        [InlineData(new[] { 3, 3, 6, 1, 3 }, 16)]
        [InlineData(new[] { 3, 2, 6, 1, 3 }, 0)]
        public void ThreeOfAKind_ReturnSumOfNumbersOrZero(int[] dice, int expectedResult)
        {
            //Arrange
            PointsCalculator pointsCalculator = new PointsCalculator();
            //Act
            int result = pointsCalculator.GetMultipleOfAKind(dice,3);
            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(new[] { 1, 1, 1, 1, 3 }, 7)]
        [InlineData(new[] { 1, 1, 1, 3, 2 }, 0)]
        public void FourOfAKind_ReturnSumOfNumbersOrZero(int[] dice, int expectedResult)
        {
            //Arrange
            PointsCalculator pointsCalculator = new PointsCalculator();
            //Act
            int result = pointsCalculator.GetMultipleOfAKind(dice,4);
            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Yahtzee_Return100IfFiveSameDices()
        {
            //Arrange
            PointsCalculator pointsCalculator = new PointsCalculator();
            int[] dice = { 4, 4, 4, 4, 4 };
            //Act
            int result = pointsCalculator.Yahtzee(dice);
            //Assert
            Assert.Equal(100, result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 2, 2, 2 })]
        [InlineData(new[] { 2, 2, 2, 2, 1 })]
        [InlineData(new[] { 2, 2, 1, 2, 2 })]
        public void Yahtzee_Return0IfNotSameDices(int[] dice)
        {
            //Arrange
            PointsCalculator pointsCalculator = new PointsCalculator();
            //Act
            int result = pointsCalculator.Yahtzee(dice);
            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void FullHouse_Return25IfPairAndThreeOfAKind()
        {
            //Arrange
            PointsCalculator pointsCalculator = new PointsCalculator();
            int[] dice = { 5, 5, 5, 2, 2 };
            //Act
            int result = pointsCalculator.FullHouse(dice);
            //Assert
            Assert.Equal(25, result);
        }
    }
}
