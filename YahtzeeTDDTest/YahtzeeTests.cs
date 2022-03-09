using System;
using System.Collections.Generic;
using Xunit;
using YahtzeeTDD;

namespace YahtzeeTDDTest
{
    public class YahtzeeTests
    {
        [Theory]
        [InlineData(new[] { 1, 1, 1, 1, 1 }, 5)]
        [InlineData(new[] { 1, 1, 1, 1, 2 }, 4)]
        [InlineData(new[] { 2, 2, 2, 2, 2 }, 0)]

        public void TestOnes(int[] dice, int expectedResult)
        {
            //Arrange
            PointsCalculator pointsCalculator = new PointsCalculator();
            //Act
            int result = pointsCalculator.GetOnes(dice);
            //Assert
            Assert.Equal(expectedResult,result);
        }

        [Theory]
        [InlineData(new[] { 2, 2, 2, 2, 2 }, 10)]
        [InlineData(new[] { 2, 2, 2, 2, 3 }, 8)]
        [InlineData(new[] { 1, 1, 1, 1, 1}, 0)]
        public void TestTwos(int[] dice, int expectedResult)
        {
            //Arrange
            PointsCalculator pointsCalculator = new PointsCalculator();
            //Act
            int result = pointsCalculator.GetTwos(dice);
            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
