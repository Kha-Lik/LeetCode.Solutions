namespace LeetCode.DynamicProgramming._1749;

public class Solution
{
    public int MaxAbsoluteSum(int[] A) {
        int s = 0, min = 0, max = 0;
        foreach (var a in A) {
            s += a;
            min = Math.Min(min, s);
            max = Math.Max(max, s);
        }
        return max - min;
    }
}