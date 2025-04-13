# 345 - Reverse Vowels of a String

## Problem

Given a string ``s``, reverse only all the vowels in the string and return it.

The vowels are ``'a'``, ``'e'``, ``'i'``, ``'o'``, and ``'u'``, and they can appear in both lower and upper cases, more than once.

### Examples

- **Input:** s = "IceCreAm" → **Output:** "AceCreIm"
- **Input:** s = "leetcode" → **Output:** "leotcede"

### Constraints

- ``1 <= s.length <= 3 * 10^5``
- ``s`` consist of **printable ASCII** characters.

## Solution

### Complexity

- **Time complexity:** $$O(N)$$
- **Space complexity:** $$O(N)$$

### Code

You can find the solution code in the [ReverseVowels.cs](./ReverseVowels.cs) file.

```csharp
public class Solution
{
    public string ReverseVowels(string s)
    {
        HashSet<char> vowels = new HashSet<char> {
        'a', 'e', 'i', 'o', 'u',
        'A', 'E', 'I', 'O', 'U'
        };

        char[] chars = s.ToCharArray();
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !vowels.Contains(chars[left]))
            {
                left++;
            }

            while (left < right && !vowels.Contains(chars[right]))
            {
                right--;
            }

            if (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }
        }

        return new string(chars);
    }
}
```

### ✅ Unit Tests

You can find unit test cases in the [ReverseVowelsTests.cs](../../Solutions.Tests/ReverseVowelsTests.cs) file.

```csharp
public class ReverseVowelsTests
{
    [Fact]
    public void ReverseVowels_Example1()
    {
        // Arrange
        var solution = new Solution();
        string s = "IceCreAm";
        string expected = "AceCreIm";

        // Act
        var result = solution.ReverseVowels(s);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseVowels_Example2()
    {
        // Arrange
        var solution = new Solution();
        string s = "leetcode";
        string expected = "leotcede";

        // Act
        var result = solution.ReverseVowels(s);

        // Assert
        Assert.Equal(expected, result);
    }
}
```
