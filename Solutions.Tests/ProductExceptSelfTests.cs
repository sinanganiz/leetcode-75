using Solutions.ProductOfArrayExceptSelf;

namespace Solutions.Tests;

public class ProductExceptSelfTests
{
    [Fact]
    public void ProductExceptSelf_Example1()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = [1, 2, 3, 4];
        int[] expected = [24, 12, 8, 6];

        // Act
        var result = solution.ProductExceptSelf(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ProductExceptSelf_Example2()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = [-1, 1, 0, -3, 3];
        int[] expected = [0, 0, 9, 0, 0];

        // Act
        var result = solution.ProductExceptSelf(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}
