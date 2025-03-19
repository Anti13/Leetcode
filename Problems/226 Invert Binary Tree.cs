/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode rig;ht
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        DFS(root);

        return root;
    }

    private void DFS(TreeNode root)
    {
        if(root == null) return;
        if(root.left == null && root.right == null) return;

        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;

        DFS(root.left);
        DFS(root.right);
    }
}