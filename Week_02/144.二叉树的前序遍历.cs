/*
 * @lc app=leetcode.cn id=144 lang=csharp
 *
 * [144] 二叉树的前序遍历
 */

// @lc code=start
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
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            helper1(root, list);
            return list;
        }
        public void helper1(TreeNode node, List<int> list)
        {
            if(node != null)
            {
                list.Add(node.val);
                if (node.left != null)
                    helper1(node.left, list);
                if (node.right != null)
                    helper1(node.right, list);
            }
        }
}
// @lc code=end

