using System.Linq;
using LeetCode.Algorithms._1502;
using NUnit.Framework;

namespace LeetCode.Algorithms.Tests;

[TestFixture]
public class _1502_Tests {
    
    private static readonly int[] Arr = Enumerable.Range(1, 400_000_000).ToArray();

    [Test]
    [TestCase(new[] {3, 5, 1}, true)]
    [TestCase(new[] {0, 0, 1}, false)]
    [TestCase(new[] {0, 0, 0, 0}, true)]
    public void HashSetSolution_CorrectAnswer(int[] arr, bool expected)
    {
        var solution = new HashSetSolution();

        var res = solution.CanMakeArithmeticProgression(arr);
        
        Assert.That(res == expected);
    }

    [Test]
    public void HashSetSolution_LongArray()
    {
        var solution = new HashSetSolution();

        var res = solution.CanMakeArithmeticProgression(Arr);
        
        Assert.True(res);
    }

    [Test]
    public void NaiveSolution_LongArray()
    {
        var solution = new NaiveSolution();

        var res = solution.CanMakeArithmeticProgression(Arr);
        
        Assert.True(res);
    }
}