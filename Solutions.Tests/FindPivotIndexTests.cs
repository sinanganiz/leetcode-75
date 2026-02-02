using Solutions.FindPivotIndex;

namespace Solutions.Tests;

public class FindPivotIndexTests
{
    [Fact]
    public void PivotIndexTest1()
    {
        var solution = new Solution();
        var result = solution.PivotIndex(new int[] { 1, 7, 3, 6, 5, 6 });
        Assert.Equal(3, result);
    }

    [Fact]
    public void PivotIndexTest2()
    {
        var solution = new Solution();
        var result = solution.PivotIndex(new int[] { 1, 2, 3 });
        Assert.Equal(-1, result);
    }

    [Fact]
    public void PivotIndexTest3()
    {
        var solution = new Solution();
        var result = solution.PivotIndex(new int[] { 2, 1, -1 });
        Assert.Equal(0, result);
    }

    [Fact]
    public void PivotIndexTest4()
    {
        var solution = new Solution();
        var result = solution.PivotIndex(new int[] { -1, -1, -1, -1, -1, 0 });
        Assert.Equal(2, result);
    }

    [Fact]
    public void PivotIndexTest5()
    {
        var solution = new Solution();
        var result = solution.PivotIndex(new int[] { 1 });
        Assert.Equal(0, result);
    }

    [Fact]
    public void PivotIndexTest6()
    {
        var solution = new Solution();
        var result = solution.PivotIndex(new int[] { 0, 0, 0, 0, 1 });
        Assert.Equal(4, result);
    }

    [Fact]
    public void PivotIndexTest7()
    {
        var solution = new Solution();
        var result = solution.PivotIndex(new int[] { -1, -1, 0, 1, 1, 0 });
        Assert.Equal(5, result);
    }

    [Fact]
    public void PivotIndexTest8()
    {
        var solution = new Solution();
        var result = solution.PivotIndex(new int[] { 1, 2, 3, 4, 5 });
        Assert.Equal(-1, result);
    }

    [Fact]
    public void PivotIndexTest9()
    {
        var solution = new Solution();
        var result = solution.PivotIndex(new int[] { 0, 0, 0 });
        Assert.Equal(0, result);
    }

    [Fact]
    public void PivotIndexTest10()
    {
        var solution = new Solution();
        var result = solution.PivotIndex(new int[] { -1, -1, -1, 0, 1, 1 });
        Assert.Equal(0, result);
    }
}
