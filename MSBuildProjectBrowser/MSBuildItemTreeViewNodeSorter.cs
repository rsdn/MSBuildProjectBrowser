using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace MSBuildProjectBrowser
{
	class MSBuildTreeViewNodeSorter : IComparer, IComparer<TreeNode>
	{
		#region IComparer Members

		public int Compare(object x, object y)
		{
			return Compare((TreeNode)x, (TreeNode)y);
		}

		#endregion

		#region IComparer<TreeNode> Members

		public int Compare(TreeNode x, TreeNode y)
		{
			if (x.Tag != null && y.Tag == null)
				return 1;

			if (x.Tag == null && y.Tag != null)
				return -1;

			return x.Text.CompareTo(y.Text);
		}

		public bool Equals(TreeNode x, TreeNode y)
		{
			return Compare(x, y) == 0;
		}

		public int GetHashCode(TreeNode obj)
		{
			return obj.Text.GetHashCode();
		}

		#endregion
	}
}
