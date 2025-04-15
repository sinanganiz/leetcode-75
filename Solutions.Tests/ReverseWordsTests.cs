using Solutions.ReverseWordsInAString;

namespace Solutions.Tests;

public class ReverseWordsTests
{
    [Fact]
    public void ReverseWords_Example1()
    {
        // Arrange
        var solution = new Solution();
        string s = "the sky is blue";
        string expected = "blue is sky the";

        // Act
        var result = solution.ReverseWords(s);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseWords_Example2()
    {
        // Arrange
        var solution = new Solution();
        string s = "  hello world  ";
        string expected = "world hello";

        // Act
        var result = solution.ReverseWords(s);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseWords_Example3()
    {
        // Arrange
        var solution = new Solution();
        string s = "a good   example";
        string expected = "example good a";

        // Act
        var result = solution.ReverseWords(s);

        // Assert
        Assert.Equal(expected, result);
    }
}
