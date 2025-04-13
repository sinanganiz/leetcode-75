using Solutions.CanPlaceFlowers;

namespace Solutions.Tests;

public class CanPlaceFlowersTests
{
    [Fact]
    public void CanPlaceFlowers_Example1()
    {
        // Arrange
        var solution = new Solution();
        int[] flowerbed = { 1, 0, 0, 0, 1 };
        int n = 1;
        bool expected = true;

        // Act
        var result = solution.CanPlaceFlowers(flowerbed, n);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CanPlaceFlowers_Example2()
    {
        // Arrange
        var solution = new Solution();
        int[] flowerbed = { 1, 0, 0, 0, 1 };
        int n = 2;
        bool expected = false;

        // Act
        var result = solution.CanPlaceFlowers(flowerbed, n);

        // Assert
        Assert.Equal(expected, result);
    }
}
