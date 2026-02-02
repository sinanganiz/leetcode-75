
namespace Solutions.FindTheHighestAltitude;

public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        var currentAltitude = 0;
        var maxAltitude = 0;
        for (int i = 0; i < gain.Length; i++)
        {
            currentAltitude += gain[i];
            if(currentAltitude > maxAltitude)
                maxAltitude = currentAltitude;
        }

        return maxAltitude;
    }
}