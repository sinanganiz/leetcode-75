using Solutions.MaximumAverageSubarray1;

namespace Solutions.Tests;

public class MaximumAverageSubarray1Tests
{
    [Fact]
    public void MaximumAverageSubarrayTest1()
    {
        var solution = new Solution();
        var result = solution.FindMaxAverage(new int[] { 1, 12, -5, -6, 50, 3 }, 4);
        Assert.Equal(12.75000, result, 5);
    }

    [Fact]
    public void MaximumAverageSubarrayTest2()
    {
        var solution = new Solution();
        var result = solution.FindMaxAverage(new int[] { 5 }, 1);
        Assert.Equal(5.00000, result, 5);
    }

    [Fact]
    public void MaximumAverageSubarrayTest3()
    {
        var solution = new Solution();
        var result = solution.FindMaxAverage(new int[] { 0, 1, 1, 3, 3 }, 4);
        Assert.Equal(2.00000, result, 5);
    }

    [Fact]
    public void MaximumAverageSubarrayTest4()
    {
        var solution = new Solution();
        var result = solution.FindMaxAverage(new int[] { -1 }, 1);
        Assert.Equal(-1.00000, result, 5);
    }

    [Fact]
    public void MaximumAverageSubarrayTest5()
    {
        var solution = new Solution();
        var result = solution.FindMaxAverage(new int[] { 1, 2, 3, 4, 5 }, 5);
        Assert.Equal(3.00000, result, 5);
    }

    [Fact]
    public void MaximumAverageSubarrayTest6()
    {
        var solution = new Solution();
        var result = solution.FindMaxAverage(new int[] { -1, -2, -3, -4 }, 2);
        Assert.Equal(-1.50000, result, 5);
    }

    [Fact]
    public void MaximumAverageSubarrayTest7()
    {
        var solution = new Solution();
        var result = solution.FindMaxAverage(new int[] { 8, 1, 5, 9, 6 }, 3);
        Assert.Equal(6.66667, result, 5);
    }

    [Fact]
    public void MaximumAverageSubarrayTest8()
    {
        var solution = new Solution();
        var result = solution.FindMaxAverage(new int[] { 0, 4, 0, 3, 2 }, 1);
        Assert.Equal(4.00000, result, 5);
    }

    [Fact]
    public void MaximumAverageSubarrayTest9()
    {
        var solution = new Solution();
        var result = solution.FindMaxAverage(new int[] { 3, 3, 4, 3, 0 }, 3);
        Assert.Equal(3.33333, result, 5);
    }

    [Fact]
    public void MaximumAverageSubarrayTest10()
    {
        var solution = new Solution();
        var result = solution.FindMaxAverage(new int[] { 100, -100, 100, -100 }, 2);
        Assert.Equal(0.00000, result, 5);
    }

}