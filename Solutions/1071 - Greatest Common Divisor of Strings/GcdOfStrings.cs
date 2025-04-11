using System.Numerics;

namespace Solutions.GreatestCommonDivisorOfStrings;

public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (!(str1 + str2).Equals(str2 + str1))
        {
            return "";
        }

        int gcdLength = (int)BigInteger.GreatestCommonDivisor(str1.Length, str2.Length);

        return str1.AsSpan().Slice(0, gcdLength).ToString();
    }
}