
using Solutions.MoveZeroes;

namespace Solutions.Tests;

public class MoveZeroesTests
{
    [Fact]
    public void MoveZeroesTest1()
    {
        var solution = new Solution();
        int[] nums = [0, 1, 0, 3, 12];
        solution.MoveZeroes(nums);
        Assert.Equal(new int[] { 1, 3, 12, 0, 0 }, nums);
    }

    [Fact]
    public void MoveZeroesTest2()
    {
        var solution = new Solution();
        int[] nums = [0];
        solution.MoveZeroes(nums);
        Assert.Equal(new int[] { 0 }, nums);
    }

    [Fact]
    public void MoveZeroesTest3()
    {
        var solution = new Solution();
        int[] nums = [1, 2, 3];
        solution.MoveZeroes(nums);
        Assert.Equal(new int[] { 1, 2, 3 }, nums);
    }

    [Fact]
    public void MoveZeroesTest4()
    {
        var solution = new Solution();
        int[] nums = [0, 0, 1];
        solution.MoveZeroes(nums);
        Assert.Equal(new int[] { 1, 0, 0 }, nums);
    }

    [Fact]
    public void MoveZeroesTest5()
    {
        var solution = new Solution();
        int[] nums = [2, 1];
        solution.MoveZeroes(nums);
        Assert.Equal(new int[] { 2, 1 }, nums);
    }

    [Fact]
    public void MoveZeroesTest6()
    {
        var solution = new Solution();
        int[] nums = [0, 0, 0, 0];
        solution.MoveZeroes(nums);
        Assert.Equal(new int[] { 0, 0, 0, 0 }, nums);
    }

}
