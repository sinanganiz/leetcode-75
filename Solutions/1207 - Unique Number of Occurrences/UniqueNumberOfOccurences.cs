namespace Solutions.UniqueNumberOfOccurences;

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int num in arr)
        {
            dict.TryGetValue(num, out int count);
            dict[num] = count + 1;
        }

        var occurencesArr = dict.Values.ToArray();
        HashSet<int> occurencesUniq = new HashSet<int>(occurencesArr);

        return occurencesUniq.Count == occurencesArr.Length;
    }
}
