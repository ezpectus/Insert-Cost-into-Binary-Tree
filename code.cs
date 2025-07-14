// TreeInserter.cs
using System;
using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class TreeInserter {
    private TreeNode root = new TreeNode(0);

    public IList<int> InsertCost(int[] targets) {
        var result = new List<int>();

        foreach (var num in targets) {
            result.Add(Insert(num));
        }

        return result;
    }

    private int Insert(int val) {
        TreeNode curr = root;
        int cost = 0;

        while (true) {
            if (val == curr.val) return 0; // already in the tree
            else if (val < curr.val) {
                if (curr.left == null) {
                    curr.left = new TreeNode(val);
                    cost++;
                    break;
                } else {
                    curr = curr.left;
                    cost++;
                }
            } else {
                if (curr.right == null) {
                    curr.right = new TreeNode(val);
                    cost++;
                    break;
                } else {
                    curr = curr.right;
                    cost++;
                }
            }
        }

        return cost;
    }
}
