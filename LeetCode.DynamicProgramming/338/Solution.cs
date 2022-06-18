namespace LeetCode.DynamicProgramming._338;

public class Solution {
    public int[] CountBits(int n) {
        var arr = new int[n+1];
        for(int i = 1; i<=n; i++){
            arr[i] = i%2 is 0 ? arr[i/2] : arr[i/2]+1;
        }
        return arr;
    }
}