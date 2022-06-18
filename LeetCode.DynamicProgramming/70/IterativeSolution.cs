namespace LeetCode.DynamicProgramming._70;

public class IterativeSolution
{
    public int ClimbStairs(int n)
    {
        var table = new int[n+1];
        table[0] = 1;
        for (int i = 0; i < n; i++)
        {
            if (i + 1 <= n) table[i + 1] += table[i];
            if (i + 2 <= n) table[i + 2] += table[i];
        }

        return table[n];
    }
}