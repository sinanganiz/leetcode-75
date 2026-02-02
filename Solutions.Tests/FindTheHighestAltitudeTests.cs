using Solutions.FindTheHighestAltitude;

namespace Solutions.Tests;

public class FindTheHighestAltitudeTests
{
    [Fact]
    public void LargestAltitudeTest1()
    {
        var solution = new Solution();
        var result = solution.LargestAltitude(new int[] { -5, 1, 5, 0, -7 });
        Assert.Equal(1, result);
    }

    [Fact]
    public void LargestAltitudeTest2()
    {
        var solution = new Solution();
        var result = solution.LargestAltitude(new int[] { -4, -3, -2, -1, 4, 3, 2 });
        Assert.Equal(0, result);
    }

    [Fact]
    public void LargestAltitudeTest3()
    {
        var solution = new Solution();
        var result = solution.LargestAltitude(new int[] { 1, 2, 3, 4, 5 });
        Assert.Equal(15, result);
    }

    [Fact]
    public void LargestAltitudeTest4()
    {
        var solution = new Solution();
        var result = solution.LargestAltitude(new int[] { -1, -2, -3, -4, -5 });
        Assert.Equal(0, result);
    }

    [Fact]
    public void LargestAltitudeTest5()
    {
        var solution = new Solution();
        var result = solution.LargestAltitude(new int[] { 5 });
        Assert.Equal(5, result);
    }

    [Fact]
    public void LargestAltitudeTest6()
    {
        var solution = new Solution();
        var result = solution.LargestAltitude(new int[] { -5 });
        Assert.Equal(0, result);
    }

    [Fact]
    public void LargestAltitudeTest8()
    {
        var solution = new Solution();
        var result = solution.LargestAltitude(new int[] { 0, 0, 0, 0 });
        Assert.Equal(0, result);
    }

    [Fact]
    public void LargestAltitudeTest9()
    {
        var solution = new Solution();
        var result = solution.LargestAltitude(new int[] { 10, -5, 3, -8, 15 });
        Assert.Equal(15, result);
    }

    [Fact]
    public void LargestAltitudeTest10()
    {
        var solution = new Solution();
        var result = solution.LargestAltitude(new int[] { 52, -91, 72 });
        Assert.Equal(52, result);
    }
}
