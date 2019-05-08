/**
WithDelegate

Copyright (c) 2012 Masahiko SHOJI

This software is released under the MIT License.

http://opensource.org/licenses/mit-license.php

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WithDelegate
{
	public class WdPictureBox : System.Windows.Forms.PictureBox
	{
		///////////////////////////////////////////////////////////////////////
		delegate void WdRefreshCallback();
		public void WdRefresh()		// Since Refresh exists, it was referred to as WdRefresh. 
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
			if(this.InvokeRequired)
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void SetBackColorCallback(Color col);
		public void SetBackColor(Color col)
		{
			if(this.InvokeRequired)
			{
				SetBackColorCallback d = new SetBackColorCallback(SetBackColor);
				this.Invoke(d, new object[] { col });
			}
			else
			{
				this.BackColor = col;
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdSetBackColorCallback(Color col);
		public void WdSetBackColor(Color col)
		{
			if(this.InvokeRequired)
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
		delegate void WdSetImageCallback(Image image);
		public void WdSetImage(Image image)
		{
			if (this.InvokeRequired)
			{
				WdSetImageCallback d = new WdSetImageCallback(WdSetImage);
				this.Invoke(d, new object[] { image });
			}
			else
			{
				this.Image = image;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate Image WdGetImageCallback();
		public Image WdGetImage()
		{
			if (this.InvokeRequired)
			{
				WdGetImageCallback d = new WdGetImageCallback(WdGetImage);
				return (Image)this.Invoke(d, new object[] {  });
			}
			else
			{
				return this.Image;
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
		delegate void WdSetSizeModeCallback(PictureBoxSizeMode mode);
		public void WdSetSizeMode(PictureBoxSizeMode mode)       // Since SelectionStart exists, it was referred to as WdSelectionStart. 
		{
			if (this.InvokeRequired)
			{
				WdSetSizeModeCallback d = new WdSetSizeModeCallback(WdSetSizeMode);
				this.Invoke(d, new object[] { mode });
			}
			else
			{
				this.SizeMode = mode;
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
		delegate Point WdGetLocationCallback();
		public Point WdGetLocation()       // Since SelectionStart exists, it was referred to as WdSelectionStart. 
		{
			if (this.InvokeRequired)
			{
				WdGetLocationCallback d = new WdGetLocationCallback(WdGetLocation);
				return (Point)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Location;
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
		delegate void WdSetParentCallback(Control control);
		public void WdSetParent(Control control)
		{
			if (this.InvokeRequired)
			{
				WdSetParentCallback d = new WdSetParentCallback(WdSetParent);
				this.Invoke(d, new object[] { control });
			}
			else
			{
				this.Parent = control;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate Control WdGetParentCallback();
		public Control WdGetParent()
		{
			if (this.InvokeRequired)
			{
				WdGetParentCallback d = new WdGetParentCallback(WdGetParent);
				return (Control)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Parent;
			}
		}
		////////////////////////////////////////////////////////////////
	}
}
