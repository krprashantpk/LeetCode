using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Easy
{
    public class RomanConverter
    {
        public static readonly Dictionary<char, int> ROMAN_CHARACTERS = new Dictionary<char, int>
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };
        public static int ConvertToInt(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) throw new ArgumentNullException("input");
            int result = 0;
            var lastIndex = input.Length - 1;

            if (!ROMAN_CHARACTERS.TryGetValue(input[lastIndex], out int current)) throw new ArgumentException("Invalid Input");

            var previous = current;
            for (int i = lastIndex; i >= 0; i--)
            {
                if (!ROMAN_CHARACTERS.TryGetValue(input[i], out current)) throw new ArgumentException("Invalid Input");

                if (current >= previous) result += current;
                else result -= current;
                previous = current;
            }

            return result;
        }
    }
}
