using LeetCode.Algorithms._70;
using LeetCode.DynamicProgramming._70;
using NUnit.Framework;

namespace LeetCode.DynamicProgramming.Tests;

public class _70_Tests {

    [Test]
    [TestCase(2, 2)]
    [TestCase(3, 3)]
    [TestCase(4, 5)]
    [TestCase(5, 8)]
    public void ClimbStairs_RecursiveSolution_CorrectResult(int n, int expected)
    {
        var solution = new RecursiveSolution();

        var result = solution.ClimbStairs(n);
        
        Assert.That(result == expected);
    }

    [Test]
    [TestCase(2, 2)]
    [TestCase(3, 3)]
    [TestCase(4, 5)]
    [TestCase(5, 8)]
    public void ClimbStairs_IterativeSolution_CorrectResult(int n, int expected)
    {
        var solution = new IterativeSolution();

        var result = solution.ClimbStairs(n);
        
        Assert.That(result == expected);
    }
}