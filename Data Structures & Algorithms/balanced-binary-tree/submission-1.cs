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

public class Solution {
    public bool IsBalanced(TreeNode root) {
        bool balanced = true;
        DFS(root, ref balanced);
        return balanced;
    }
    private int DFS(TreeNode root, ref bool balanced){
        if(root == null) return 0;
        int l = DFS(root.left, ref balanced);
        int r = DFS(root.right, ref balanced);
        balanced = balanced && Math.Abs(l-r)<=1;
        return 1+Math.Max(l,r);
    }
}
