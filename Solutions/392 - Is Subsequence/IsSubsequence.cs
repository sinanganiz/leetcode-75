using System.Text;

namespace Solutions.IsSubsequence;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int si = 0, ti = 0;

        if (s.Length == 0)
            return true;

        if (t.Length == 0 && s.Length > 0)
            return false;

        while (ti < t.Length)
        {
            if (s[si] == t[ti])
            {
                si++;
                if (si == s.Length) return true;
            }

            ti++;
        }


        return si == s.Length;
    }
}