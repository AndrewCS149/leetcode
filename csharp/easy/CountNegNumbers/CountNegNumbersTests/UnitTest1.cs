using System;
using Xunit;
using static CountNegNumbers.Program;

namespace CountNegNumbersTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnCorrectNumberOfNegatives()
        {
            // arrange
            int[][] grid =
            {
                new int[]{4, 3, 2, -1 },
                new int[]{3, 2, 1, -1 },
                new int[]{1, 1, -1, -2 },
                new int[]{-1, -1, -2, -3 }
            };

            // act
            int result = CountNegatives(grid);

            // assert
            Assert.Equal(8, result);
        }
    }
}