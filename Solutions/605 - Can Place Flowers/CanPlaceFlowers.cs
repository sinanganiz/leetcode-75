namespace Solutions.CanPlaceFlowers;

public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0) return true;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            int leftPlot = i > 0 ? flowerbed[i - 1] : 0;
            int rightPlot = i < flowerbed.Length - 1 ? flowerbed[i + 1] : 0;

            if (leftPlot == 0 && flowerbed[i] == 0 && rightPlot == 0)
            {
                flowerbed[i] = 1;
                n--;
            }

        }

        return n <= 0;
    }
}