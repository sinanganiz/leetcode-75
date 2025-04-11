
using Solutions.GreatestCommonDivisorOfStrings;

namespace Solutions.Tests;

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
