using System.Text;

namespace Solutions.MergeStringsAlternately;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int len1 = word1.Length;
        int len2 = word2.Length;
        StringBuilder sb = new StringBuilder(len1 + len2);

        int i = 0;
        int j = 0;

        while (i < len1 || j < len2)
        {
            if (i < len1) sb.Append(word1[i++]);
            if (j < len2) sb.Append(word2[j++]);
        }

        return sb.ToString();
    }
}