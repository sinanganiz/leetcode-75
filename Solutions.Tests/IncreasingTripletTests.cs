using Solutions.IncreasingTripletSubsequence;

namespace Solutions.Tests;

public class IncreasingTripletTests
{
    [Fact]
    public void IncreasingTriplet_Example1()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = [1, 2, 3, 4, 5];
        bool expected = true;

        // Act
        var result = solution.IncreasingTriplet(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void IncreasingTriplet_Example2()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = [5, 4, 3, 2, 1];
        bool expected = false;

        // Act
        var result = solution.IncreasingTriplet(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void IncreasingTriplet_Example3()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = [2, 1, 5, 0, 4, 6];
        bool expected = true;

        // Act
        var result = solution.IncreasingTriplet(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}
