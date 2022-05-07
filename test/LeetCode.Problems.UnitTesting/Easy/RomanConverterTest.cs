using LeetCode.Problems.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode.Problems.UnitTesting.Easy
{
    public class RomanConverterTest
    {

        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void WhenInputIsValidResultShouldReturn(string input, int result)
        {
            Assert.Equal(RomanConverter.ConvertToInt(input), result);

        }

        [Theory]
        [InlineData(null, 3)]
        [InlineData("", 3)]
        [InlineData(" ", 3)]
        [InlineData("   ", 3)]
        public void WhenInputIsNullResultShouldReturn(string input, int result)
        {
            Assert.Throws<ArgumentNullException>(() => RomanConverter.ConvertToInt(input));

        }

        [Theory]
        [InlineData("LK", 3)]
        [InlineData("JIL", 3)]
        [InlineData("KK", 3)]
        public void WhenInputIsInValidResultShouldReturn(string input, int result)
        {
            Assert.Throws<ArgumentException>(() => RomanConverter.ConvertToInt(input));

        }
    }
}

