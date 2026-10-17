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
    public TreeNode InvertTree(TreeNode root) {
        Queue<TreeNode> visit = new Queue<TreeNode>();
        visit.Enqueue(root);
        while(visit.Count!=0){
            var node = visit.Dequeue();
            if(node==null){
                continue;
            }
            var temp = node.left; //swap
            node.left = node.right;
            node.right = temp;

            visit.Enqueue(node.left);
            visit.Enqueue(node.right);
        }
        return root;
    }
}
