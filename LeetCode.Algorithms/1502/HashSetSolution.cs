using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms._1502;

public class HashSetSolution
{
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        var hset = new HashSet<int>(arr);
        var min = int.MaxValue;
        var max = int.MinValue;
        foreach (var t in arr)
        {
            min = Math.Min(min, t);
            max = Math.Max(max, t);
        }
        var diff = (max - min) / (arr.Length - 1);

        if (hset.Count != arr.Length && hset.Count > 1)
            return false;
        
        for (var i = 1; i < arr.Length; i++)
        {
            if (!hset.Contains(min + diff * i)) return false;
        }
        
        return true;
    }
}