using System;
using System.Collections.Generic;
using Xunit;
using YahtzeeTDD;

namespace YahtzeeTDDTest
{
    public class YahtzeeTests
    {
        [Theory]
        [InlineData(new[]{1,1,1,1,1},5)]
        public void TestOnes(int[] dice, int expectedResult)
        {
            //Arrange
            PointsCalculator pointsCalculator = new PointsCalculator();
            //Act
            int result = pointsCalculator.GetOnes(dice);
            //Assert
            Assert.Equal(expectedResult,result);
        }
    }
}
