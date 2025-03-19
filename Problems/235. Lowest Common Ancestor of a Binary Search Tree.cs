/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        
        var ppath =new Stack<TreeNode>();
        var qpath =new Stack<TreeNode>();

        DFS(root, p.val, ppath);
        DFS(root, q.val, qpath);

        TreeNode lowest = null;
        while(true)
        {
            if(ppath.Count == 0 || qpath.Count == 0)
            {
                break;
            }
            var pnode = ppath.Pop();
            var qnode = qpath.Pop();

            if(qnode.val == pnode.val)
            {
                lowest = qnode;
            }
        }

        return lowest;
    }

        private bool DFS(TreeNode root, int number, Stack<TreeNode> stack)
        {
            if(root == null)
            {
                return false;
            }

            if(root.val == number)      
            {
                stack.Push(root);
                 return true;
            }

            
             if(DFS(root.left, number, stack))
             {
                stack.Push(root);
                return true;
             }

             if(DFS(root.right, number, stack))
             {
                stack.Push(root);
                return true;
             }


            return false;
        }
    
}