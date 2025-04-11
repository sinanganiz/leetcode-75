# 1768 - Merge Strings Alternately

## Problem

You are given two strings ``word1`` and ``word2``. Merge the strings by adding letters in alternating order, starting with ``word1``. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return *the merged string*.

### Examples

- **Input:** word1 = "abc", word2 = "pqr" → **Output:** "apbqcr"
- **Input:** word1 = "ab", word2 = "pqrs" → **Output:** "apbqrs"
- **Input:** word1 = "abcd", word2 = "pq" → **Output:** "apbqcd"

### Constraints

- ``1 <= word1.length, word2.length <= 100``
- ``word1`` and ``word2`` consist of lowercase English letters.

## Solution

### Complexity

- **Time complexity:** $$O(n)$$
- **Space complexity:** $$O(n)$$

### Code

You can find the solution code in the [MergeAlternately.cs](MergeAlternately.cs) file.

```csharp
public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int len1 = word1.Length;
        int len2 = word2.Length;
        StringBuilder sb = new StringBuilder(len1 + len2);

        int i = 0;
        int j = 0;

        while (i < len1 || j < len2)
        {
            if (i < len1) sb.Append(word1[i++]);
            if (j < len2) sb.Append(word2[j++]);
        }

        return sb.ToString();
    }
}
```

### ✅ Unit Tests

You can find unit test cases in the [MergeAlternatelyTests.cs](../../Solutions.Tests/MergeAlternatelyTests.cs) file.

```csharp
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
```
