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
        int longest = 0;
        var queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, 1));
        while(queue.Count>0){
            (var node, int depth) = queue.Dequeue();
            if(node==null){
                longest = Math.Max(longest, depth-1);
                continue;
            }
            queue.Enqueue((node.left, depth+1));
            queue.Enqueue((node.right, depth+1));
        }
        return longest;
    }
}
