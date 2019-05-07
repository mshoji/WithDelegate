using System.Windows.Forms;
using System.Drawing;

namespace WithDelegate
{
	public class WdPanel : System.Windows.Forms.Panel
	{
		///////////////////////////////////////////////////////////////////////
		delegate void WdRefreshCallback();
		public void WdRefresh()     // Since Refresh exists, it was referred to as WdRefresh. 
		{
			if (this.InvokeRequired)
			{
				WdRefreshCallback d = new WdRefreshCallback(WdRefresh);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Refresh();
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
		delegate void WdSetBackColorCallback(Color col);
		public void WdSetBackColor(Color col)
		{
			if (this.InvokeRequired)
			{
				WdSetBackColorCallback d = new WdSetBackColorCallback(WdSetBackColor);
				this.Invoke(d, new object[] { col });
			}
			else
			{
				this.BackColor = col;
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
		delegate void WdInvalidateCallback();
		public void WdInvalidate()
		{
			if (this.InvokeRequired)
			{
				WdInvalidateCallback d = new WdInvalidateCallback(WdInvalidate);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Invalidate();
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdUpdateCallback();
		public void WdUpdate()
		{
			if (this.InvokeRequired)
			{
				WdUpdateCallback d = new WdUpdateCallback(WdUpdate);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Update();
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetSizeCallback(Size size);
		public void WdSetSize(Size size)       // Since SelectionStart exists, it was referred to as WdSelectionStart. 
		{
			if (this.InvokeRequired)
			{
				WdSetSizeCallback d = new WdSetSizeCallback(WdSetSize);
				this.Invoke(d, new object[] { size });
			}
			else
			{
				this.Size = size;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate Size WdGetSizeCallback();
		public Size WdGetSize()       // Since SelectionStart exists, it was referred to as WdSelectionStart. 
		{
			if (this.InvokeRequired)
			{
				WdGetSizeCallback d = new WdGetSizeCallback(WdGetSize);
				return (Size)this.Invoke(d, new object[] {  });
			}
			else
			{
				return this.Size;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetLocationCallback(Point point);
		public void WdSetLocation(Point point)       // Since SelectionStart exists, it was referred to as WdSelectionStart. 
		{
			if (this.InvokeRequired)
			{
				WdSetLocationCallback d = new WdSetLocationCallback(WdSetLocation);
				this.Invoke(d, new object[] { point });
			}
			else
			{
				this.Location = point;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetNameCallback(string name);
		public void WdSetName(string name)       // Since SelectionStart exists, it was referred to as WdSelectionStart. 
		{
			if (this.InvokeRequired)
			{
				WdSetNameCallback d = new WdSetNameCallback(WdSetName);
				this.Invoke(d, new object[] { name });
			}
			else
			{
				this.Name = name;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdControlsRemoveCallback(Control control);
		public void WdControlsRemove(Control control)       // Since SelectionStart exists, it was referred to as WdSelectionStart. 
		{
			if (this.InvokeRequired)
			{
				WdControlsRemoveCallback d = new WdControlsRemoveCallback(WdControlsRemove);
				this.Invoke(d, new object[] { control });
			}
			else
			{
				this.Controls.Remove(control);
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdControlsAddCallback(Control control);
		public void WdControlsAdd(Control control)       // Since SelectionStart exists, it was referred to as WdSelectionStart. 
		{
			if (this.InvokeRequired)
			{
				WdControlsAddCallback d = new WdControlsAddCallback(WdControlsAdd);
				this.Invoke(d, new object[] { control });
			}
			else
			{
				this.Controls.Add(control);
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetAutoSizeCallback(bool bFlg);
		public void WdSetAutoSize(bool bFlg)       // Since SelectionStart exists, it was referred to as WdSelectionStart. 
		{
			if (this.InvokeRequired)
			{
				WdSetAutoSizeCallback d = new WdSetAutoSizeCallback(WdSetAutoSize);
				this.Invoke(d, new object[] { bFlg });
			}
			else
			{
				this.AutoSize = bFlg;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetAutoScrollCallback(bool bFlg);
		public void WdSetAutoScroll(bool bFlg)       // Since SelectionStart exists, it was referred to as WdSelectionStart. 
		{
			if (this.InvokeRequired)
			{
				WdSetAutoScrollCallback d = new WdSetAutoScrollCallback(WdSetAutoScroll);
				this.Invoke(d, new object[] { bFlg });
			}
			else
			{
				this.AutoScroll= bFlg;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetHorizontalScrollValueCallback(int val);
		public void WdSetHorizontalScrollValue(int val)
		{
			if (this.InvokeRequired)
			{
				WdSetHorizontalScrollValueCallback d = new WdSetHorizontalScrollValueCallback(WdSetHorizontalScrollValue);
				this.Invoke(d, new object[] { val });
			}
			else
			{
				this.HorizontalScroll.Value = val;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int WdGetHorizontalScrollValueCallback();
		public int WdGetHorizontalScrollValue()
		{
			if (this.InvokeRequired)
			{
				WdGetHorizontalScrollValueCallback d = new WdGetHorizontalScrollValueCallback(WdGetHorizontalScrollValue);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.HorizontalScroll.Value;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetVerticalScrollValueCallback(int val);
		public void WdSetVerticalScrollValue(int val)
		{
			if (this.InvokeRequired)
			{
				WdSetVerticalScrollValueCallback d = new WdSetVerticalScrollValueCallback(WdSetVerticalScrollValue);
				this.Invoke(d, new object[] { val });
			}
			else
			{
				this.VerticalScroll.Value = val;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int WdGetVerticalScrollValueCallback();
		public int WdGetVerticalScrollValue()
		{
			if (this.InvokeRequired)
			{
				WdGetVerticalScrollValueCallback d = new WdGetVerticalScrollValueCallback(WdGetVerticalScrollValue);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.VerticalScroll.Value;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetAutoScrollPositionCallback(Point point);
		public void WdSetAutoScrollPosition(Point point)
		{
			if (this.InvokeRequired)
			{
				WdSetAutoScrollPositionCallback d = new WdSetAutoScrollPositionCallback(WdSetAutoScrollPosition);
				this.Invoke(d, new object[] { point });
			}
			else
			{
				this.AutoScrollPosition = point;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate Point WdGetAutoScrollPositionCallback();
		public Point WdGetAutoScrollPosition()
		{
			if (this.InvokeRequired)
			{
				WdGetAutoScrollPositionCallback d = new WdGetAutoScrollPositionCallback(WdGetAutoScrollPosition);
				return (Point)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.AutoScrollPosition;
			}
		}
		////////////////////////////////////////////////////////////////
	}
}
