namespace Solutions.ProductOfArrayExceptSelf;

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