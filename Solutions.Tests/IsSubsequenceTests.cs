using Solutions.IsSubsequence;

namespace Solutions.Tests;

public class IsSubsequenceTests
{
    [Fact]
    public void IsSubsequenceTest1()
    {
        var solution = new Solution();
        var result = solution.IsSubsequence("abc", "ahbgdc");
        Assert.True(result);
    }

    [Fact]
    public void IsSubsequenceTest2()
    {
        var solution = new Solution();
        var result = solution.IsSubsequence("axc", "ahbgdc");
        Assert.False(result);
    }

    [Fact]
    public void IsSubsequenceTest3()
    {
        var solution = new Solution();
        var result = solution.IsSubsequence("", "ahbgdc");
        Assert.True(result);
    }

    [Fact]
    public void IsSubsequenceTest4()
    {
        var solution = new Solution();
        var result = solution.IsSubsequence("abc", "");
        Assert.False(result);
    }

    [Fact]
    public void IsSubsequenceTest5()
    {
        var solution = new Solution();
        var result = solution.IsSubsequence("", "");
        Assert.True(result);
    }

    [Fact]
    public void IsSubsequenceTest6()
    {
        var solution = new Solution();
        var result = solution.IsSubsequence("ace", "abcde");
        Assert.True(result);
    }

    [Fact]
    public void IsSubsequenceTest7()
    {
        var solution = new Solution();
        var result = solution.IsSubsequence("aec", "abcde");
        Assert.False(result);
    }

    [Fact]
    public void IsSubsequenceTest8()
    {
        var solution = new Solution();
        var result = solution.IsSubsequence("aaa", "aaa");
        Assert.True(result);
    }

    [Fact]
    public void IsSubsequenceTest9()
    {
        var solution = new Solution();
        var result = solution.IsSubsequence("ab", "baab");
        Assert.True(result);
    }

    [Fact]
    public void IsSubsequenceTest10()
    {
        var solution = new Solution();
        var result = solution.IsSubsequence("acb", "ahbgdc");
        Assert.False(result);
    }
}