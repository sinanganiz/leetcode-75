
namespace Solutions.FindPivotIndex;

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        var totalSum = nums.Sum();
        var leftSum = 0;

        for (int i = 0; i< nums.Length; i++)
        {
            var rightSum = totalSum - leftSum - nums[i];

            if (leftSum == rightSum)
                return i;

            leftSum += nums[i];
        }

        return -1;
    }
}
