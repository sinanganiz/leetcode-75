# 1431 - Kids With the Greatest Number of Candies

## Problem

There are ``n`` kids with candies. You are given an integer array ``candies``, where each ``candies[i]`` represents the number of candies the ``i th`` kid has, and an integer ``extraCandies``, denoting the number of extra candies that you have.

Return *a boolean array ``result`` of length ``n``, where ``result[i]`` is ``true`` if, after giving the ``i th`` kid all the ``extraCandies``, they will have the **greatest** number of candies among all the kids, or ``false`` otherwise.*

Note that **multiple** kids can have the **greatest** number of candies.

### Examples

- **Input:** candies = [2,3,5,1,3], extraCandies = 3 → **Output:** [true,true,true,false,true]
- **Input:** candies = [4,2,1,1,2], extraCandies = 1 → **Output:** [true,false,false,false,false]
- **Input:** candies = [12,1,12], extraCandies = 10 → **Output:** [true,false,true]

### Constraints

- ``n == candies.length``
- ``2 <= n <= 100``
- ``1 <= candies[i] <= 100``
- ``1 <= extraCandies <= 50``

## Solution

### Complexity

- **Time complexity:** $$O(n)$$
- **Space complexity:** $$O(n)$$

### Code

You can find the solution code in the [KidsWithCandies.cs](KidsWithCandies.cs) file.

```csharp
public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var greatestCandy = 0;
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] > greatestCandy) greatestCandy = candies[i];
        }

        var isGreatestAfterExtraCandiesList = new List<bool>(candies.Length);
        
        for (int i = 0; i < candies.Length; i++)
        {
            isGreatestAfterExtraCandiesList.Add(candies[i] + extraCandies >= greatestCandy);
        }

        return isGreatestAfterExtraCandiesList;
    }
}
```

### ✅ Unit Tests

You can find unit test cases in the [KidsWithCandiesTests.cs](../../Solutions.Tests/KidsWithCandiesTests.cs) file.

```csharp
public class KidsWithTheGreatestNumberOfCandiesTests
{
    [Fact]
    public void KidsWithTheGreatestNumberOfCandies_Example1()
    {
        // Arrange
        var solution = new Solution();
        int[] candies = { 2, 3, 5, 1, 3 };
        int extraCandies = 3;
        bool[] expected = { true, true, true, false, true };

        // Act
        var result = solution.KidsWithCandies(candies, extraCandies);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void KidsWithTheGreatestNumberOfCandies_Example2()
    {
        // Arrange
        var solution = new Solution();
        int[] candies = { 4, 2, 1, 1, 2 };
        int extraCandies = 1;
        bool[] expected = { true, false, false, false, false };

        // Act
        var result = solution.KidsWithCandies(candies, extraCandies);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void KidsWithTheGreatestNumberOfCandies_Example3()
    {
        // Arrange
        var solution = new Solution();
        int[] candies = { 12, 1, 12 };
        int extraCandies = 10;
        bool[] expected = { true, false, true };

        // Act
        var result = solution.KidsWithCandies(candies, extraCandies);

        // Assert
        Assert.Equal(expected, result);
    }
}
```
