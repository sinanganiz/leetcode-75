namespace Solutions.FindTheDifferenceOfTwoArrays;

public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);
        
        HashSet<int> uniqueNums1 = new HashSet<int>();
        foreach (int num in set1)
        {

            if (!set2.Contains(num))
            {
                uniqueNums1.Add(num);
            }
        }

        HashSet<int> uniqueNums2 = new HashSet<int>();
        foreach (int num in set2)
        {
            if (!set1.Contains(num))
            {
                uniqueNums2.Add(num);
            }
        }
        var result = new List<IList<int>>();
        result.Add(uniqueNums1.ToList());
        result.Add(uniqueNums2.ToList());

        return result;
    }
}
