# 605 - Can Place Flowers

## Problem

You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in **adjacent** plots.

Given an integer array ``flowerbed`` containing ``0``'s and ``1``'s, where ``0`` means empty and ``1`` means not empty, and an integer ``n``, return *``true`` if ``n`` new flowers can be planted in the ``flowerbed`` without violating the no-adjacent-flowers rule and ``false`` otherwise.*

### Examples

- **Input:** flowerbed = [1,0,0,0,1], n = 1 → **Output:** true
- **Input:** flowerbed = [1,0,0,0,1], n = 2 → **Output:** false

### Constraints

- ``1 <= flowerbed.length <= 2 * 10^4``
- ``flowerbed[i]`` is ``0`` or ``1``.
- There are no two adjacent flowers in ``flowerbed``.
- ``0 <= n <= flowerbed.length``

## Solution

### Complexity

- **Time complexity:** $$O(N)$$
- **Space complexity:** $$O(1)$$

### Code

You can find the solution code in the [CanPlaceFlowers.cs](CanPlaceFlowers.cs) file.

```csharp
public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0) return true;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            int leftPlot = i > 0 ? flowerbed[i - 1] : 0;
            int rightPlot = i < flowerbed.Length - 1 ? flowerbed[i + 1] : 0;

            if (leftPlot == 0 && flowerbed[i] == 0 && rightPlot == 0)
            {
                flowerbed[i] = 1;
                n--;
            }

        }

        return n <= 0;
    }
}
```

### ✅ Unit Tests

You can find unit test cases in the [CanPlaceFlowersTests.cs](../../Solutions.Tests/CanPlaceFlowersTests.cs) file.

```csharp
public class CanPlaceFlowersTests
{
    [Fact]
    public void CanPlaceFlowers_Example1()
    {
        // Arrange
        var solution = new Solution();
        int[] flowerbed = { 1, 0, 0, 0, 1 };
        int n = 1;
        bool expected = true;

        // Act
        var result = solution.CanPlaceFlowers(flowerbed, n);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CanPlaceFlowers_Example2()
    {
        // Arrange
        var solution = new Solution();
        int[] flowerbed = { 1, 0, 0, 0, 1 };
        int n = 2;
        bool expected = false;

        // Act
        var result = solution.CanPlaceFlowers(flowerbed, n);

        // Assert
        Assert.Equal(expected, result);
    }
}
```
