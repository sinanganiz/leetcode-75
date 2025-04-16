
using Solutions.StringCompression;

namespace Solutions.Tests;

public class CompressTests
{
    [Fact]
    public void Compress_Example1()
    {
        // Arrange
        var solution = new Solution();
        char[] chars = ['a', 'a', 'b', 'b', 'c', 'c', 'c'];
        int expected = 6;

        // Act
        var result = solution.Compress(chars);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Compress_Example2()
    {
        // Arrange
        var solution = new Solution();
        char[] chars = ['a'];
        int expected = 1;

        // Act
        var result = solution.Compress(chars);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Compress_Example3()
    {
        // Arrange
        var solution = new Solution();
        char[] chars = ['a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'];
        int expected = 4;

        // Act
        var result = solution.Compress(chars);

        // Assert
        Assert.Equal(expected, result);
    }
}
