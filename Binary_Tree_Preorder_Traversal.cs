using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/928/
    /// Given the root of a binary tree, return the preorder traversal of its nodes' values.
    /// root = [1,null,2,3]=>Output: [1,2,3]
    /// root = []=>Output: []
    /// root = [1]=>Output: [1]
    /// </summary>
    public class Binary_Tree_Preorder_Traversal
    {
        public Binary_Tree_Preorder_Traversal()
        {
            //IList<int> val = { 1, null, 2, 3 };
            //IList<int> val =  [];
            //IList<int> val =  [1];
            TreeNode node = new TreeNode(1, null, new TreeNode(2, new TreeNode(3, null, null), null));
            //TreeNode node = new TreeNode(0,null,null);
            //TreeNode node = new TreeNode(0, null, null);
            var res = PreorderTraversal(node);
            var ab = 0;
        }
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int> { };
            var res = PreorderTraverse(root, list);
            return res;
        }
        public IList<int> PreorderTraverse(TreeNode root, IList<int> input)
        {
            if (root == null)
            {
                return input;
            }
            input.Add(root.val);
            PreorderTraverse(root.left, input);
            PreorderTraverse(root.right, input);
            return input;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
