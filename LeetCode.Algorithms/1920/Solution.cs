namespace LeetCode.Algorithms._1920;

public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        var newNums = new int[nums.Length];
        int i = 0;
        foreach (var num in nums)
        {
            newNums[i] = nums[num];
            i++;
        }

        return newNums;
    }
}