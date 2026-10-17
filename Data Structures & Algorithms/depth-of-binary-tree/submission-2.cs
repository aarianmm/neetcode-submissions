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
    public int MaxDepth(TreeNode root) {
        int level = 0;
        var queue = new Queue<TreeNode>(); //bfs
        queue.Enqueue(root);
        while(queue.Count>0 && root!=null){
            int width = queue.Count;
            for(int i=0; i<width; i++){ //clear our level and enqueue next level
                var node = queue.Dequeue();
                if(node.left!=null){
                    queue.Enqueue(node.left);
                }
                if(node.right!=null){
                    queue.Enqueue(node.right);
                }
            }
            level++;
        }
        return level;
    }
}
