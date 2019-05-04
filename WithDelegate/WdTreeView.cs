using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WithDelegate
{
	//class WdTreeView
	public class WdTreeView : System.Windows.Forms.TreeView
	{
		////////////////////////////////////////////////////////////////
		delegate string WdGetTextCallback();
		public string WdGetText()
		{
			if (this.InvokeRequired)
			{
				WdGetTextCallback d = new WdGetTextCallback(WdGetText);
				return (string)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Text;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetTextCallback(string str);
		public void WdSetText(string str)
		{
			if (this.InvokeRequired)
			{
				WdSetTextCallback d = new WdSetTextCallback(WdSetText);
				this.Invoke(d, new object[] { str });
			}
			else
			{
				this.Text = str;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdVisibleCallback(bool flg);
		public void WdVisible(bool flg)
		{
			if (this.InvokeRequired)
			{
				WdVisibleCallback d = new WdVisibleCallback(WdVisible);
				this.Invoke(d, new object[] { flg });
			}
			else
			{
				this.Visible = flg;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdEnableCallback(bool flg);
		public void WdEnable(bool flg)
		{
			if (this.InvokeRequired)
			{
				WdEnableCallback d = new WdEnableCallback(WdEnable);
				this.Invoke(d, new object[] { flg });
			}
			else
			{
				this.Enabled = flg;
			}
		}
#if false
		////////////////////////////////////////////////////////////////
		delegate void WdSelectCallback();
		public void WdSelect()      // Since Select exists, it was referred to as WdSelect. 
		{
			if (this.InvokeRequired)
			{
				WdSelectCallback d = new WdSelectCallback(WdSelect);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Select();
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdSetSelectNodeCallback(TreeNode node);
		public void WdSetSelectNode(TreeNode node)
		{
			if (this.InvokeRequired)
			{
				WdSetSelectNodeCallback d = new WdSetSelectNodeCallback(WdSetSelectNode);
				this.Invoke(d, new object[] { node });
			}
			else
			{
				this.SelectedNode = node;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate TreeNode WdGetSelectNodeCallback();
		public TreeNode WdGetSelectNode()
		{
			if (this.InvokeRequired)
			{
				WdGetSelectNodeCallback d = new WdGetSelectNodeCallback(WdGetSelectNode);
				return (TreeNode)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.SelectedNode;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdFocusCallback();
		public void WdFocus()
		{
			if (this.InvokeRequired)
			{
				WdFocusCallback d = new WdFocusCallback(WdFocus);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Focus();
			}
		}
		////////////////////////////////////////////////////////////////
		delegate TreeNode WdGetTopNodeCallback();
		public TreeNode WdGetTopNode()
		{
			if (this.InvokeRequired)
			{
				WdGetTopNodeCallback d = new WdGetTopNodeCallback(WdGetTopNode);
				return (TreeNode)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.TopNode;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate TreeNodeCollection WdGetNodesCallback();
		public TreeNodeCollection WdGetNodes()
		{
			if (this.InvokeRequired)
			{
				WdGetNodesCallback d = new WdGetNodesCallback(WdGetNodes);
				return (TreeNodeCollection)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Nodes;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate TreeNode WdGetSelectedNodeCallback();
		public TreeNode WdGetSelectedNode()
		{
			if (this.InvokeRequired)
			{
				WdGetSelectedNodeCallback d = new WdGetSelectedNodeCallback(WdGetSelectedNode);
				return (TreeNode)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.SelectedNode;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate bool WdNodesAddCallback(TreeNode nodeChild);
		public bool WdNodesAdd(TreeNode nodeChild)
		{
			if (this.InvokeRequired)
			{
				WdNodesAddCallback d = new WdNodesAddCallback(WdNodesAdd);
				return (bool)this.Invoke(d, new object[] { nodeChild });
			}
			else
			{
				if (this.SelectedNode == null)
					return false;

				this.Nodes.Add(nodeChild);
				return true;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate bool WdNodesAddRangeCallback(TreeNode[] nodes);
		public bool WdNodesAddRange(TreeNode[] nodes)
		{
			if (this.InvokeRequired)
			{
				WdNodesAddRangeCallback d = new WdNodesAddRangeCallback(WdNodesAddRange);
				return (bool)this.Invoke(d, new object[] { nodes });
			}
			else
			{
				//if (this.SelectedNode == null)
				//	return false;

				this.Nodes.AddRange(nodes);
				return true;
			}
		}
		////////////////////////////////////////////////////////////////
#if false
		delegate bool WdAddNodeToNodeCollectionCallback(TreeNodeCollection treeNodeCollection, TreeNode nodeChild);
		public bool WdAddNodeToNodeCollection(TreeNodeCollection treeNodeCollection,TreeNode nodeChild)
		{
			if (this.InvokeRequired)
			{
				WdAddNodeToNodeCollectionCallback d = new WdAddNodeToNodeCollectionCallback(WdAddNodeToNodeCollection);
				return (bool)this.Invoke(d, new object[] { treeNodeCollection, nodeChild });
			}
			else
			{
				if (treeNodeCollection == null)
					return false;
				treeNodeCollection.Add(nodeChild);
				return true;
			}
		}
		////////////////////////////////////////////////////////////////
#endif
	}
}
