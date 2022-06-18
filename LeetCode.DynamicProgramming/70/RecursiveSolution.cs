using System.Collections.Generic;

namespace LeetCode.Algorithms._70;

public class RecursiveSolution
{
    public int ClimbStairs(int n, Dictionary<int, int>? memo = null)
    {
        memo ??= new Dictionary<int, int>();
        if (memo.ContainsKey(n)) return memo[n];
        if (n < 2) return 1;

        return memo[n] = ClimbStairs(n - 1, memo) + ClimbStairs(n - 2, memo);
    }

    //          4
    //        /   
    //       3     
    //     /  \   
    //    2   1  
    //  /  \
    // 1   0
    
    
    // this comment is not related to the 70th task
    // just example of how hash table is working
    // 'user' => 21
    // var arr = new string[10];
    // 21 % 10 = 1
    // arr[1].Add('user')
}