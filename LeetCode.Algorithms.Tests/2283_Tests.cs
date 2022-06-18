using LeetCode.Algorithms._2283;
using NUnit.Framework;

namespace LeetCode.Algorithms.Tests;

[TestFixture]
public class _2283_Tests {

    [Test]
    [TestCase("1210", true)]
    public void DigitCount_CorrectAnswer(string num, bool expected)
    {
        var solution = new Solution();

        var res = solution.DigitCount(num);
        
        Assert.That(res == expected);
    }
}