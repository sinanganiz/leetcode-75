using Solutions.FindTheDifferenceOfTwoArrays;

namespace Solutions.Tests;

public class FindTheDifferenceOfTwoArraysTests
{
    [Fact]
    public void DifferenceOfTwoArraysTest1()
    {
        var solution = new Solution();
        var result = solution.FindDifference(new int[] { 1, 2, 3 }, new int[] { 2, 4, 6 });
        Assert.Equal(new List<int> { 1, 3 }, result[0].OrderBy(x => x).ToList());
        Assert.Equal(new List<int> { 4, 6 }, result[1].OrderBy(x => x).ToList());
    }

    [Fact]
    public void DifferenceOfTwoArraysTest2()
    {
        var solution = new Solution();
        var result = solution.FindDifference(new int[] { 1, 2, 3, 3 }, new int[] { 1, 1, 2, 2 });
        Assert.Equal(new List<int> { 3 }, result[0].OrderBy(x => x).ToList());
        Assert.Empty(result[1]);
    }

    [Fact]
    public void DifferenceOfTwoArraysTest3()
    {
        var solution = new Solution();
        var result = solution.FindDifference(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 });
        Assert.Empty(result[0]);
        Assert.Empty(result[1]);
    }

    [Fact]
    public void DifferenceOfTwoArraysTest4()
    {
        var solution = new Solution();
        var result = solution.FindDifference(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 });
        Assert.Equal(new List<int> { 1, 2, 3 }, result[0].OrderBy(x => x).ToList());
        Assert.Equal(new List<int> { 4, 5, 6 }, result[1].OrderBy(x => x).ToList());
    }

    [Fact]
    public void DifferenceOfTwoArraysTest5()
    {
        var solution = new Solution();
        var result = solution.FindDifference(new int[] { 1, 1, 1, 1 }, new int[] { 2, 2, 2, 2 });
        Assert.Equal(new List<int> { 1 }, result[0].OrderBy(x => x).ToList());
        Assert.Equal(new List<int> { 2 }, result[1].OrderBy(x => x).ToList());
    }

    [Fact]
    public void DifferenceOfTwoArraysTest6()
    {
        var solution = new Solution();
        var result = solution.FindDifference(new int[] { -1, -2, -3 }, new int[] { -2, -4, -6 });
        Assert.Equal(new List<int> { -3, -1 }, result[0].OrderBy(x => x).ToList());
        Assert.Equal(new List<int> { -6, -4 }, result[1].OrderBy(x => x).ToList());
    }

    [Fact]
    public void DifferenceOfTwoArraysTest7()
    {
        var solution = new Solution();
        var result = solution.FindDifference(new int[] { 1 }, new int[] { 1 });
        Assert.Empty(result[0]);
        Assert.Empty(result[1]);
    }

    [Fact]
    public void DifferenceOfTwoArraysTest8()
    {
        var solution = new Solution();
        var result = solution.FindDifference(new int[] { 1 }, new int[] { 2 });
        Assert.Equal(new List<int> { 1 }, result[0].OrderBy(x => x).ToList());
        Assert.Equal(new List<int> { 2 }, result[1].OrderBy(x => x).ToList());
    }

    [Fact]
    public void DifferenceOfTwoArraysTest9()
    {
        var solution = new Solution();
        var result = solution.FindDifference(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 6, 7 });
        Assert.Equal(new List<int> { 1, 2 }, result[0].OrderBy(x => x).ToList());
        Assert.Equal(new List<int> { 6, 7 }, result[1].OrderBy(x => x).ToList());
    }

    [Fact]
    public void DifferenceOfTwoArraysTest10()
    {
        var solution = new Solution();
        var result = solution.FindDifference(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 });
        Assert.Empty(result[0]);
        Assert.Empty(result[1]);
    }

}
