# 443 - String Compression

## Problem

Given an array of characters ``chars``, compress it using the following algorithm:

Begin with an empty string ``s``. For each group of **consecutive repeating characters** in ``chars``:

- If the group's length is ``1``, append the character to ``s``.
- Otherwise, append the character followed by the group's length.

The compressed string ``s`` **should not be returned separately**, but instead, be stored **in the input character array ``chars``**. Note that group lengths that are ``10`` or longer will be split into multiple characters in ``chars``.

After you are done **modifying the input array**, return *the new length of the array.*

You must write an algorithm that uses only constant extra space.

### Examples

- **Input:** chars = ["a","a","b","b","c","c","c"] → **Output:** 6
- **Input:** chars = ["a"] → **Output:** 1
- **Input:** chars = ["a","b","b","b","b","b","b","b","b","b","b","b","b"] → **Output:** 4

### Constraints

- ``1 <= chars.length <= 2000``
- ``chars[i]`` is a lowercase English letter, uppercase English letter, digit, or symbol

## Solution

### Complexity [NOT COMPLETED]

- **Time complexity:** $$O(N)$$
- **Space complexity:** $$O(1)$$

### Code [NOT COMPLETED]

You can find the solution code in the [Compress.cs](./Compress.cs) file.

```csharp

```

### ✅ Unit Tests

You can find unit test cases in the [CompressTests.cs](../../Solutions.Tests/CompressTests.cs) file.

```csharp
public class CompressTests
{
    [Fact]
    public void Compress_Example1()
    {
        // Arrange
        var solution = new Solution();
        char[] chars = ['a', 'a', 'b', 'b', 'c', 'c', 'c'];
        int expected = 6;

        // Act
        var result = solution.Compress(chars);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Compress_Example2()
    {
        // Arrange
        var solution = new Solution();
        char[] chars = ['a'];
        int expected = 1;

        // Act
        var result = solution.Compress(chars);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Compress_Example3()
    {
        // Arrange
        var solution = new Solution();
        char[] chars = ['a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'];
        int expected = 4;

        // Act
        var result = solution.Compress(chars);

        // Assert
        Assert.Equal(expected, result);
    }
}
```
