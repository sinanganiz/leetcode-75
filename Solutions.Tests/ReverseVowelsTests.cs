using Solutions.ReverseVowelsOfAString;

namespace Solutions.Tests;

public class ReverseVowelsTests
{
    [Fact]
    public void ReverseVowels_Example1()
    {
        // Arrange
        var solution = new Solution();
        string s = "IceCreAm";
        string expected = "AceCreIm";

        // Act
        var result = solution.ReverseVowels(s);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseVowels_Example2()
    {
        // Arrange
        var solution = new Solution();
        string s = "leetcode";
        string expected = "leotcede";

        // Act
        var result = solution.ReverseVowels(s);

        // Assert
        Assert.Equal(expected, result);
    }
}
