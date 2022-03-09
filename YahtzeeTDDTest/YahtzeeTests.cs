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

        public void SameNumberCombinations_ReturnSumOfSaidNumber(int[] dice, int number, int expectedResult)
        {
            //Arrange
            PointsCalculator pointsCalculator = new PointsCalculator();
            //Act
            int result = pointsCalculator.GetNumbers(dice,number);
            //Assert
            Assert.Equal(expectedResult,result);
        }

    }
}
