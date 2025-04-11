
using Solutions.MergeStringsAlternately;

namespace Solutions.Tests;

public class MergeStringsAlternatelyTests
{
    [Fact]
    public void MergeAlternately_EqualLengthStrings_ReturnsCorrectResult()
    {
        var solution = new Solution();
        var result = solution.MergeAlternately("abc", "pqr");
        Assert.Equal("apbqcr", result);
    }

    [Fact]
    public void MergeAlternately_Word2IsLonger_AppendsRemaining()
    {
        var solution = new Solution();
        var result = solution.MergeAlternately("ab", "pqrs");
        Assert.Equal("apbqrs", result);
    }

    [Fact]
    public void MergeAlternately_Word1IsLonger_AppendsRemaining()
    {
        var solution = new Solution();
        var result = solution.MergeAlternately("abcd", "pq");
        Assert.Equal("apbqcd", result);
    }
}
