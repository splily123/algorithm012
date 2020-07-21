/*
 * @lc app=leetcode.cn id=94 lang=csharp
 *
 * [94] 二叉树的中序遍历
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
using System.Collections;
public class Solution {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            helper(root, list);
            return list;
        }

        public void helper(TreeNode node, IList<int> list)
        {
            if(node != null){
            if (node.left != null)
               helper(node.left, list);
            list.Add(node.val);
            if (node.right != null)
                helper(node.right, list);
            }
        }
}
// @lc code=end

