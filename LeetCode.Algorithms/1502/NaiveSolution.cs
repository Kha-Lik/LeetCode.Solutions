using System;

namespace LeetCode.Algorithms._1502;

public class NaiveSolution
{
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        var diff = arr[1] - arr[0];
        for(int i = 1; i < arr.Length; i++){
            if (arr[i-1] + diff != arr[i]) return false;
        }
        return true;
    }
}