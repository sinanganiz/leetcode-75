# 238 - Product of Array Except Self

## Problem

Given an integer array ``nums``, return *an array ``answer`` such that ``answer[i]`` is equal to the product of all the elements of ``nums`` except ``nums[i]``.*

The product of any prefix or suffix of ``nums`` is **guaranteed** to fit in a **32-bit** integer.

You must write an algorithm that runs in ``O(n)`` time and without using the division operation.

### Examples

- **Input:** nums = [1,2,3,4] → **Output:** [24,12,8,6]
- **Input:** nums = [-1,1,0,-3,3] → **Output:** [0,0,9,0,0]

### Constraints

- ``2 <= nums.length <= 10^5``
- ``-30 <= nums[i] <= 30``
- The input is generated such that ``answer[i]`` is **guaranteed** to fit in a **32-bit** integer.

## Solution

### Complexity

- **Time complexity:** $$O(N)$$
- **Space complexity:** $$O(1)$$

### Code

You can find the solution code in the [ProductExceptSelf.cs](./ProductExceptSelf.cs) file.

```csharp
public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];

        int prefix = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }

        int suffix = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= suffix;
            suffix *= nums[i];
        }

        return result;
    }
}
```

### ✅ Unit Tests

You can find unit test cases in the [ProductExceptSelfTests.cs](../../Solutions.Tests/ProductExceptSelfTests.cs) file.

```csharp
public class ProductExceptSelfTests
{
    [Fact]
    public void ProductExceptSelf_Example1()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = [1, 2, 3, 4];
        int[] expected = [24, 12, 8, 6];

        // Act
        var result = solution.ProductExceptSelf(nums);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ProductExceptSelf_Example2()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = [-1, 1, 0, -3, 3];
        int[] expected = [0, 0, 9, 0, 0];

        // Act
        var result = solution.ProductExceptSelf(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}
```
