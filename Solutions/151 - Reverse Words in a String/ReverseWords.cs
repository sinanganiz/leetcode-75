using System.Text;

namespace Solutions.ReverseWordsInAString;

public class Solution
{
    public string ReverseWords(string s)
    {
        StringBuilder sb = new();
        int i = s.Length - 1;

        while (i >= 0)
        {
            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }

            if (i < 0) break;

            int wordEnd = i;

            while (i >= 0 && s[i] != ' ')
            {
                i--;
            }

            if (sb.Length > 0)
            {
                sb.Append(' ');
            }

            sb.Append(s, i + 1, wordEnd - i);
        }

        return sb.ToString();
    }
}