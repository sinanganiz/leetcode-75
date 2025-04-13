
using Solutions.KidsWithTheGreatestNumberOfCandies;

namespace Solutions.Tests;

public class KidsWithTheGreatestNumberOfCandiesTests
{
    [Fact]
    public void KidsWithTheGreatestNumberOfCandies_Example1()
    {
        // Arrange
        var solution = new Solution();
        int[] candies = { 2, 3, 5, 1, 3 };
        int extraCandies = 3;
        bool[] expected = { true, true, true, false, true };

        // Act
        var result = solution.KidsWithCandies(candies, extraCandies);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void KidsWithTheGreatestNumberOfCandies_Example2()
    {
        // Arrange
        var solution = new Solution();
        int[] candies = { 4, 2, 1, 1, 2 };
        int extraCandies = 1;
        bool[] expected = { true, false, false, false, false };

        // Act
        var result = solution.KidsWithCandies(candies, extraCandies);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void KidsWithTheGreatestNumberOfCandies_Example3()
    {
        // Arrange
        var solution = new Solution();
        int[] candies = { 12, 1, 12 };
        int extraCandies = 10;
        bool[] expected = { true, false, true };

        // Act
        var result = solution.KidsWithCandies(candies, extraCandies);

        // Assert
        Assert.Equal(expected, result);
    }
}
