using LeetCode.DynamicProgramming._1749;
using NUnit.Framework;

namespace LeetCode.DynamicProgramming.Tests;

[TestFixture]
public class _1749_Tests {

    [Test]
    [TestCase(new[]{1,-3,2,3,-4}, 5)]
    [TestCase(new[]{2,-5,1,-4,3,-2}, 8)]
    public void MaxAbsoluteSum_CorrectAnswer(int[] arr, int expected)
    {
        var solution = new Solution();

        var res = solution.MaxAbsoluteSum(arr);
        
        Assert.True(res == expected);
    }
}