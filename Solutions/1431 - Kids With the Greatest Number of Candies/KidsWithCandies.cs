namespace Solutions.KidsWithTheGreatestNumberOfCandies;

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var greatestCandy = 0;
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] > greatestCandy) greatestCandy = candies[i];
        }

        var isGreatestAfterExtraCandiesList = new List<bool>(candies.Length);
        
        for (int i = 0; i < candies.Length; i++)
        {
            isGreatestAfterExtraCandiesList.Add(candies[i] + extraCandies >= greatestCandy);
        }

        return isGreatestAfterExtraCandiesList;
    }
}