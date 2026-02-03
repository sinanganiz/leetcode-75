using Solutions.UniqueNumberOfOccurences;

namespace Solutions.Tests;

public class UniqueNumberOfOccurencesTests
{
    [Fact]
    public void UniqueOccurrencesTest1()
    {
        var solution = new Solution();
        var result = solution.UniqueOccurrences(new int[] { 1, 2, 2, 1, 1, 3 });
        Assert.True(result);
    }

    [Fact]
    public void UniqueOccurrencesTest2()
    {
        var solution = new Solution();
        var result = solution.UniqueOccurrences(new int[] { 1, 2 });
        Assert.False(result);
    }

    [Fact]
    public void UniqueOccurrencesTest3()
    {
        var solution = new Solution();
        var result = solution.UniqueOccurrences(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 });
        Assert.True(result);
    }

    [Fact]
    public void UniqueOccurrencesTest4()
    {
        var solution = new Solution();
        var result = solution.UniqueOccurrences(new int[] { 1 });
        Assert.True(result);
    }

    [Fact]
    public void UniqueOccurrencesTest5()
    {
        var solution = new Solution();
        var result = solution.UniqueOccurrences(new int[] { 1, 1, 1, 1 });
        Assert.True(result);
    }

    [Fact]
    public void UniqueOccurrencesTest6()
    {
        var solution = new Solution();
        var result = solution.UniqueOccurrences(new int[] { 1, 2, 3 });
        Assert.False(result);
    }

    [Fact]
    public void UniqueOccurrencesTest7()
    {
        var solution = new Solution();
        var result = solution.UniqueOccurrences(new int[] { -1, -1, 1, 1, 2 });
        Assert.False(result);
    }

    [Fact]
    public void UniqueOccurrencesTest8()
    {
        var solution = new Solution();
        var result = solution.UniqueOccurrences(new int[] { 0, 0, 0, 0, 0 });
        Assert.True(result);
    }

    [Fact]
    public void UniqueOccurrencesTest9()
    {
        var solution = new Solution();
        var result = solution.UniqueOccurrences(new int[] { -1000, -1000, 1000, 1000 });
        Assert.False(result);
    }

    [Fact]
    public void UniqueOccurrencesTest10()
    {
        var solution = new Solution();
        var result = solution.UniqueOccurrences(new int[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 });
        Assert.True(result);
    }
}