# Roman to Integer

LeetCode problem : [Roman To Integer](https://leetcode.com/problems/roman-to-integer/)

Roman numerals are represented by seven different symbols: **_I, V, X, L, C, D,_** and **_M_**. Each symbol has been assigned a unique fixed integer value to it.

> Note: I represent the number 1, V represents 5, X is 10, L is 50, C is 100, D is 500, and M is 1,000.

| Symbol | Value |
| ------ | ----- |
| I      | 1     |
| V      | 5     |
| X      | 10    |
| L      | 50    |
| C      | 100   |
| D      | 500   |
| M      | 1000  |

## Solution :-

The basic principle behind converting Roman symbols to an inter value is that:-

- if a symbol placed after another of equal or greater value adds its value; e.g., II = 2 and LX = 60
- and if a symbol placed before one of greater value subtracts its value; e.g., IV = 4, XL = 40, and CD = 400.

https://github.com/krprashantpk/LeetCode/blob/40ae74cdf55d6130de3f33b7d49b3aa462117554/src/LeetCode.Problems/Easy/RomanConverter.cs#L21-L40

Find the above solution on GitHub: [krprashantpk](https://github.com/krprashantpk/LeetCode/blob/master/src/LeetCode.Problems/Easy/RomanConverter.cs)
