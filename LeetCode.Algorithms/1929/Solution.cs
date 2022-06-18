namespace LeetCode.Algorithms._1929;

public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var arr = new int[nums.Length * 2];
        nums.CopyTo(arr, 0);
        nums.CopyTo(arr, nums.Length);
        return arr;
    }
}