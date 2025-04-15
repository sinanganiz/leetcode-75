# 334 - Increasing Triplet Subsequence

## Problem

Given an integer array ``nums``, return *``true`` if there exists a triple of indices ``(i, j, k)`` such that i < j < k and ``nums[i] < nums[j] < nums[k]``*. If no such indices exists, return ``false``.

### Examples

- **Input:** nums = [1,2,3,4,5] → **Output:** true
- **Input:** nums = [5,4,3,2,1] → **Output:** false
- **Input:** nums = [2,1,5,0,4,6] → **Output:** true

### Constraints

- ``1 <= nums.length <= 5 * 10^5``
- ``-2^31 <= nums[i] <= 2^31 - 1``

**Follow up:** Could you implement a solution that runs in ``O(n)`` time complexity and ``O(1)`` space complexity?

## Solution

### Complexity

- **Time complexity:** $$O(N)$$
- **Space complexity:** $$O(1)$$

### Code

You can find the solution code in the [IncreasingTriplet.cs](./IncreasingTriplet.cs) file.

```csharp
public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3)
        {
            return false;
        }

        int first = int.MaxValue;
        int second = int.MaxValue;

        foreach (int num in nums)
        {
            if (num <= first)
            {
                first = num;
            }
            else if (num <= second)
            {
                second = num;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}
```

### ✅ Unit Tests

You can find unit test cases in the [IncreasingTripletTests.cs](../../Solutions.Tests/IncreasingTripletTests.cs) file.

```csharp
public class IncreasingTripletTests
{
    [Fact]
    public void IncreasingTriplet_Example1()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = [1, 2, 3, 4, 5];
        bool expected = true;

        // Act
        var result = solution.IncreasingTriplet(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void IncreasingTriplet_Example2()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = [5, 4, 3, 2, 1];
        bool expected = false;

        // Act
        var result = solution.IncreasingTriplet(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void IncreasingTriplet_Example3()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = [2, 1, 5, 0, 4, 6];
        bool expected = true;

        // Act
        var result = solution.IncreasingTriplet(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}
```
