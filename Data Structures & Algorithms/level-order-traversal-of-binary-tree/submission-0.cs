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
    public List<List<int>> LevelOrder(TreeNode root) {
        var sol = new List<List<int>>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        if(root==null) return sol;
        while(queue.Count>0){
            var currentLevel = new List<int>();
            int levelWidth = queue.Count;
            for(int i=0; i<levelWidth; i++){
                var node = queue.Dequeue();
                currentLevel.Add(node.val);
                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);
            }
            sol.Add(currentLevel);
        }
        return sol;
    }
}
