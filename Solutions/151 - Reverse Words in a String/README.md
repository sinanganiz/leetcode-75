# 151 - Reverse Words in a String

## Problem

Given an input string ``s``, reverse the order of the **words**.

A **word** is defined as a sequence of non-space characters. The **words** in ``s`` will be separated by at least one space.

Return *a string of the words in reverse order concatenated by a single space.*

**Note** that ``s`` may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.

### Examples

- **Input:** s = "the sky is blue" → **Output:** "blue is sky the"
- **Input:** s = "  hello world  " → **Output:** "world hello"
- **Input:** s = "a good   example" → **Output:** "example good a"

### Constraints

- ``1 <= s.length <= 10^4``
- ``s`` contains English letters (upper-case and lower-case), digits, and spaces ``' '``.
- There is **at least one** word in ``s``.

## Solution

### Complexity

- **Time complexity:** $$O(N)$$
- **Space complexity:** $$O(N)$$

### Code

You can find the solution code in the [ReverseWords.cs](./ReverseWords.cs) file.

```csharp
public class Solution
{
    public string ReverseWords(string s)
    {
        StringBuilder sb = new();
        int i = s.Length - 1;

        while (i >= 0)
        {
            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }

            if (i < 0) break;

            int wordEnd = i;

            while (i >= 0 && s[i] != ' ')
            {
                i--;
            }

            if (sb.Length > 0)
            {
                sb.Append(' ');
            }

            sb.Append(s, i + 1, wordEnd - i);
        }

        return sb.ToString();
    }
}
```

### ✅ Unit Tests

You can find unit test cases in the [ReverseWordsTests.cs](../../Solutions.Tests/ReverseWordsTests.cs) file.

```csharp
public class ReverseWordsTests
{
    [Fact]
    public void ReverseWords_Example1()
    {
        // Arrange
        var solution = new Solution();
        string s = "the sky is blue";
        string expected = "blue is sky the";

        // Act
        var result = solution.ReverseWords(s);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseWords_Example2()
    {
        // Arrange
        var solution = new Solution();
        string s = "  hello world  ";
        string expected = "world hello";

        // Act
        var result = solution.ReverseWords(s);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseWords_Example3()
    {
        // Arrange
        var solution = new Solution();
        string s = "a good   example";
        string expected = "example good a";

        // Act
        var result = solution.ReverseWords(s);

        // Assert
        Assert.Equal(expected, result);
    }
}
```
