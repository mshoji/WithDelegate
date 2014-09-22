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
using System.Drawing;
using System.Windows.Forms;

namespace WithDelegate
{
	public class WdHScrollBar : System.Windows.Forms.HScrollBar
	{
		////////////////////////////////////////////////////////////////
		delegate Rectangle GetWdBoundsCallback();
		public Rectangle GetWdBounds()
		{
			if (this.InvokeRequired)
			{
				GetWdBoundsCallback d = new GetWdBoundsCallback(GetWdBounds);
				return (Rectangle)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Bounds;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void SetWdBoundsCallback(int x, int y, int width, int height, BoundsSpecified boundsSpecified);
		public void SetWdBounds(int x, int y, int width, int height, BoundsSpecified boundsSpecified)
		{
			if (this.InvokeRequired)
			{
				SetWdBoundsCallback d = new SetWdBoundsCallback(SetWdBounds);
				this.Invoke(d, new object[] { x, y, width, height, boundsSpecified });
			}
			else
			{
				this.SetBounds(x, y, width, height, boundsSpecified);
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int GetValueCallback();
		public int GetValue()
		{
			if (this.InvokeRequired)
			{
				GetValueCallback d = new GetValueCallback(GetValue);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Value;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void SetValueCallback(int data);
		public void SetValue(int data)
		{
			if (this.InvokeRequired)
			{
				SetValueCallback d = new SetValueCallback(SetValue);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Value = data;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int GetMinimumCallback();
		public int GetMinimum()
		{
			if (this.InvokeRequired)
			{
				GetMinimumCallback d = new GetMinimumCallback(GetMinimum);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Minimum;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void SetMinimumCallback(int data);
		public void SetMinimum(int data)
		{
			if (this.InvokeRequired)
			{
				SetMinimumCallback d = new SetMinimumCallback(SetMinimum);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Minimum = data;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int GetMaximumCallback();
		public int GetMaximum()
		{
			if (this.InvokeRequired)
			{
				GetMaximumCallback d = new GetMaximumCallback(GetMaximum);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Maximum;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void SetMaximumCallback(int data);
		public void SetMaximum(int data)
		{
			if (this.InvokeRequired)
			{
				SetMaximumCallback d = new SetMaximumCallback(SetMaximum);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Maximum = data;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int GetHeightCallback();
		public int GetHeight()
		{
			if (this.InvokeRequired)
			{
				GetHeightCallback d = new GetHeightCallback(GetHeight);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Height;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void SetHeightCallback(int data);
		public void SetHeight(int data)
		{
			if (this.InvokeRequired)
			{
				SetHeightCallback d = new SetHeightCallback(SetHeight);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Height = data;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int GetWidthCallback();
		public int GetWidth()
		{
			if (this.InvokeRequired)
			{
				GetWidthCallback d = new GetWidthCallback(GetWidth);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Width;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void SetWidthCallback(int data);
		public void SetWidth(int data)
		{
			if (this.InvokeRequired)
			{
				SetWidthCallback d = new SetWidthCallback(SetWidth);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Width = data;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate string GetTextCallback();
		public string GetText()
		{
			if (this.InvokeRequired)
			{
				GetTextCallback d = new GetTextCallback(GetText);
				return (string)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Text;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void SetTextCallback(string str);
		public void SetText(string str)
		{
			if (this.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetText);
				this.Invoke(d, new object[] { str });
			}
			else
			{
				this.Text = str;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void ThisEnableCallback(bool flg);
		public void Enable(bool flg)
		{
			if (this.InvokeRequired)
			{
				ThisEnableCallback d = new ThisEnableCallback(Enable);
				this.Invoke(d, new object[] { flg });
			}
			else
			{
				this.Enabled = flg;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdVisibleCallback(bool flg);
		public void WdVisible(bool flg)		// Since Visible exists, it was referred to as WdVisible. 
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
	}
}
