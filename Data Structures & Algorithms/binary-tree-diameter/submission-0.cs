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
    public int DiameterOfBinaryTree(TreeNode root) {
        int maxDi = 0;
        DFS(root, ref maxDi);
        return maxDi;
    }
    private int DFS(TreeNode root, ref int maxDi){
        if(root == null){
            return 0;
        }
        int lHeight = DFS(root.left, ref maxDi);
        int rHeight = DFS(root.right, ref maxDi);
        maxDi = Math.Max(maxDi, lHeight+rHeight);
        return 1+Math.Max(lHeight, rHeight);
    }
}
