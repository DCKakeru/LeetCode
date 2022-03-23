/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    List<int> res = new List<int>();
    public List<int> InorderTraversal(TreeNode root)
    {
        return Helper(root).ToList();
    }
    public IList<int> Helper(TreeNode root)
    {
        if (root == null) return res;
        res.Concat(Helper(root.left));
        res.Add(root.val);
        res.Concat(Helper(root.right));
        return res;
    }
}