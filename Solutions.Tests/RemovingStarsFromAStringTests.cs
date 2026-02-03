using Solutions.RemovingStarsFromAString;

namespace Solutions.Tests;

public class RemovingStarsFromAStringTests
{
    [Fact]
    public void RemovingStarsTest1()
    {
        var solution = new Solution();
        var result = solution.RemoveStars("leet**cod*e");
        Assert.Equal("lecoe", result);
    }

    [Fact]
    public void RemovingStarsTest2()
    {
        var solution = new Solution();
        var result = solution.RemoveStars("erase*****");
        Assert.Equal("", result);
    }

    [Fact]
    public void RemovingStarsTest3()
    {
        var solution = new Solution();
        var result = solution.RemoveStars("abc");
        Assert.Equal("abc", result);
    }

    [Fact]
    public void RemovingStarsTest4()
    {
        var solution = new Solution();
        var result = solution.RemoveStars("a*");
        Assert.Equal("", result);
    }

    [Fact]
    public void RemovingStarsTest5()
    {
        var solution = new Solution();
        var result = solution.RemoveStars("ab*c");
        Assert.Equal("ac", result);
    }

    [Fact]
    public void RemovingStarsTest6()
    {
        var solution = new Solution();
        var result = solution.RemoveStars("a*b*c*");
        Assert.Equal("", result);
    }

    [Fact]
    public void RemovingStarsTest7()
    {
        var solution = new Solution();
        var result = solution.RemoveStars("abc***");
        Assert.Equal("", result);
    }

    [Fact]
    public void RemovingStarsTest8()
    {
        var solution = new Solution();
        var result = solution.RemoveStars("abcde");
        Assert.Equal("abcde", result);
    }

    [Fact]
    public void RemovingStarsTest9()
    {
        var solution = new Solution();
        var result = solution.RemoveStars("ab**cd**ef");
        Assert.Equal("ef", result);
    }
}