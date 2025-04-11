# 1071 - Greatest Common Divisor of Strings

## Problem

For two strings ``s`` and ``t``, we say "``t`` divides ``s``" if and only if ``s = t + t + t + ... + t + t`` (i.e., ``t`` is concatenated with itself one or more times).

Given two strings ``str1`` and ``str2``, return *the largest string ``x`` such that ``x`` divides both ``str1`` and ``str2``*.

### Examples

- **Input:** str1 = "ABCABC", str2 = "ABC" → **Output:** "ABC"
- **Input:** str1 = "ABABAB", str2 = "ABAB" → **Output:** "AB"
- **Input:** str1 = "LEET", str2 = "CODE" → **Output:** ""

### Constraints

- ``1 <= str1.length, str2.length <= 1000``
- ``str1`` and ``str2`` consist of English uppercase letters.

## Solution

### Complexity

Let $$m$$, $$n$$ be the lengthes of the two input strings ``str1`` and ``str2``.

- **Time complexity:** $$O(m+n)$$
- **Space complexity:** $$O(m+n)$$

### Code

```csharp
public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (!(str1 + str2).Equals(str2 + str1))
        {
            return "";
        }

        int gcdLength = (int)BigInteger.GreatestCommonDivisor(str1.Length, str2.Length);

        return str1.AsSpan().Slice(0, gcdLength).ToString();
    }
}
```

### ✅ Unit Tests

You can find unit test cases in the [GcdOfStringsTests.cs](../../Solutions.Tests/GcdOfStringsTests.cs) file.

```csharp
public class GreatestCommonDivisorOfStringsTests
{
    [Fact]
    public void GcdOfStrings_WhenFirstStringIsMultipleOfSecond_ReturnSecondString()
    {
        // Arrange
        var solution = new Solution();
        string str1 = "ABCABC";
        string str2 = "ABC";
        string expected = "ABC";

        // Act
        var result = solution.GcdOfStrings(str1, str2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GcdOfStrings_WhenBothStringsHaveCommonDivisor_ReturnLargestCommonDivisor()
    {
        // Arrange
        var solution = new Solution();
        string str1 = "ABABAB";
        string str2 = "ABAB";
        string expected = "AB";

        // Act
        var result = solution.GcdOfStrings(str1, str2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GcdOfStrings_WhenStringsHaveNoCommonDivisor_ReturnEmptyString()
    {
        // Arrange
        var solution = new Solution();
        string str1 = "LEET";
        string str2 = "CODE";
        string expected = "";

        // Act
        var result = solution.GcdOfStrings(str1, str2);

        // Assert
        Assert.Equal(expected, result);
    }
}
```
