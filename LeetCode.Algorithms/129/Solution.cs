#nullable disable
namespace LeetCode.Algorithms._129;

public class Solution {
    public int SumNumbers(TreeNode root)
    {
        return SumNumbers(root, 0);
    }

    private int SumNumbers(TreeNode root, int currentSum)
    {
        if (root is null) return 0;

        currentSum = currentSum * 10 + root.val;

        if (root.left is null && root.right is null)
            return currentSum;

        return SumNumbers(root.left, currentSum) + SumNumbers(root.right, currentSum);
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}