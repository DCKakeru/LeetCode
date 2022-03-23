
//Definition for a binary tree node.
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

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root.left == null && root.right == null)
        {
            return true;
        }
        if (root.left == null && root.right != null)
        {
            return false;
        }
        if (root.left != null && root.right == null)
        {
            return false;
        }

        if (root.left.val != root.right.val)
        {
            return false;
        }
        return (NodeCompare(root.left, root.right));
    }
    public bool NodeCompare(TreeNode leftNode, TreeNode rightNode)
    {
        if (leftNode == null && rightNode == null) return true;
        if ((leftNode != null && rightNode == null) || (leftNode == null && rightNode != null)) return false;
        var flag1 = NodeCompare(leftNode.left, rightNode.right);
        var flag2 = (leftNode.val == rightNode.val);
        var flag3 = NodeCompare(leftNode.right, rightNode.left);
        return (flag1 && flag2 && flag3);
    }
}