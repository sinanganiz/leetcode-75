namespace Solutions.StringCompression;

public class Solution
{
    public int Compress(char[] chars)
    {
        int write = 0;
        int read = 0;

        while (read < chars.Length)
        {
            char currentChar = chars[read];
            int count = 0;

            // Count char group count
            while (read < chars.Length && chars[read] == currentChar)
            {
                read++;
                count++;
            }

            chars[write++] = currentChar;

            if (count > 1)
            {
                foreach (char digit in count.ToString())
                {
                    chars[write++] = digit;
                }
            }
        }

        return write;
    }
}