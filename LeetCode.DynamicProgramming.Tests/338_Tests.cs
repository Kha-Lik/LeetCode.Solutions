using LeetCode.DynamicProgramming._338;
using NUnit.Framework;

namespace LeetCode.DynamicProgramming.Tests;

public class _338_Tests {
    
    [Test]
    [TestCase(0, new[]{0})]
    [TestCase(1, new[]{0, 1})]
    [TestCase(2, new[]{0, 1, 1})]
    [TestCase(5, new[]{0, 1, 1, 2, 1, 2})]
    [TestCase(12, new[]{0, 1, 1, 2, 1, 2, 2, 3, 1, 2, 2, 3, 2})]
    public void CountBits_LinearSolution_CorrectResult(int n, int[] expected)
    {
        var solution = new Solution();

        var result = solution.CountBits(n);
        
        Assert.AreEqual(result, expected);
    }
}