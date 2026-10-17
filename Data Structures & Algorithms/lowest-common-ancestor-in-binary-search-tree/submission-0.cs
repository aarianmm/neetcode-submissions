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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        var pPath = new List<TreeNode>(){root};
        var qPathVisited = new HashSet<TreeNode>(){root};
        TreeNode node = root;
        while(node != p){
            if(p.val>node.val){
                node = node.right;
            }
            else{
                node = node.left;
            }
            pPath.Add(node);
        }
        node = root;
        while(node != q){
            if(q.val>node.val){
                node = node.right;
            }
            else{
                node = node.left;
            }
            qPathVisited.Add(node);
        }
        for(int i = pPath.Count-1; i>=0; i--){
            
            if(qPathVisited.Contains(pPath[i])){
                return pPath[i];
            }
        }
        return root;
    }
}
