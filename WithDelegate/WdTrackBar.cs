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
	public class WdTrackBar : System.Windows.Forms.TrackBar
	{
		////////////////////////////////////////////////////////////////
		delegate Size WdGetClientSizeCallback();
		public Size WdGetClientSize()
		{
			if (this.InvokeRequired)
			{
				WdGetClientSizeCallback d = new WdGetClientSizeCallback(WdGetClientSize);
				return (Size)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.ClientSize;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate Padding WdGetMarginCallback();
		public Padding WdGetMargin()
		{
			if (this.InvokeRequired)
			{
				WdGetMarginCallback d = new WdGetMarginCallback(WdGetMargin);
				return (Padding)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Margin;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate Rectangle WdGetWdBoundsCallback();
		public Rectangle WdGetWdBounds()
		{
			if(this.InvokeRequired)
			{
				WdGetWdBoundsCallback d = new WdGetWdBoundsCallback(WdGetWdBounds);
				return (Rectangle)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Bounds;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetWdBoundsCallback(int x, int y, int width, int height, BoundsSpecified boundsSpecified);
		public void WdSetWdBounds(int x, int y, int width, int height, BoundsSpecified boundsSpecified)
		{
			if(this.InvokeRequired)
			{
				WdSetWdBoundsCallback d = new WdSetWdBoundsCallback(WdSetWdBounds);
				this.Invoke(d, new object[] { x, y, width, height, boundsSpecified });
			}
			else
			{
				this.SetBounds(x, y, width, height, boundsSpecified);
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int WdGetValueCallback();
		public int WdGetValue()
		{
			if(this.InvokeRequired)
			{
				WdGetValueCallback d = new WdGetValueCallback(WdGetValue);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Value;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetValueCallback(int data);
		public void WdSetValue(int data)
		{
			if(this.InvokeRequired)
			{
				WdSetValueCallback d = new WdSetValueCallback(WdSetValue);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Value = data;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int WdGetTickFrequencyCallback();
		public int WdGetTickFrequency()
		{
			if (this.InvokeRequired)
			{
				WdGetTickFrequencyCallback d = new WdGetTickFrequencyCallback(WdGetTickFrequency);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.TickFrequency;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetTickFrequencyCallback(int data);
		public void WdSetTickFrequency(int data)
		{
			if (this.InvokeRequired)
			{
				WdSetTickFrequencyCallback d = new WdSetTickFrequencyCallback(WdSetTickFrequency);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.TickFrequency = data;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int WdGetLargeChangeCallback();
		public int WdGetLargeChange()
		{
			if (this.InvokeRequired)
			{
				WdGetLargeChangeCallback d = new WdGetLargeChangeCallback(WdGetLargeChange);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.LargeChange;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetLargeChangeCallback(int data);
		public void WdSetLargeChange(int data)
		{
			if (this.InvokeRequired)
			{
				WdSetLargeChangeCallback d = new WdSetLargeChangeCallback(WdSetLargeChange);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.LargeChange = data;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int WdGetMinimumCallback();
		public int WdGetMinimum()
		{
			if(this.InvokeRequired)
			{
				WdGetMinimumCallback d = new WdGetMinimumCallback(WdGetMinimum);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Minimum;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetMinimumCallback(int data);
		public void WdSetMinimum(int data)
		{
			if(this.InvokeRequired)
			{
				WdSetMinimumCallback d = new WdSetMinimumCallback(WdSetMinimum);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Minimum = data;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int WdGetMaximumCallback();
		public int WdGetMaximum()
		{
			if(this.InvokeRequired)
			{
				WdGetMaximumCallback d = new WdGetMaximumCallback(WdGetMaximum);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Maximum;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetMaximumCallback(int data);
		public void WdSetMaximum(int data)
		{
			if(this.InvokeRequired)
			{
				WdSetMaximumCallback d = new WdSetMaximumCallback(WdSetMaximum);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Maximum = data;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int WdGetHeightCallback();
		public int WdGetHeight()
		{
			if(this.InvokeRequired)
			{
				WdGetHeightCallback d = new WdGetHeightCallback(WdGetHeight);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Height;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetHeightCallback(int data);
		public void WdSetHeight(int data)
		{
			if(this.InvokeRequired)
			{
				WdSetHeightCallback d = new WdSetHeightCallback(WdSetHeight);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Height = data;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int WdGetWidthCallback();
		public int WdGetWidth()
		{
			if(this.InvokeRequired)
			{
				WdGetWidthCallback d = new WdGetWidthCallback(WdGetWidth);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Width;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetWidthCallback(int data);
		public void WdSetWidth(int data)
		{
			if(this.InvokeRequired)
			{
				WdSetWidthCallback d = new WdSetWidthCallback(WdSetWidth);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Width = data;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate string WdGetTextCallback();
		public string WdGetText()
		{
			if(this.InvokeRequired)
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
			if(this.InvokeRequired)
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
		delegate void WdEnableCallback(bool flg);
		public void WdEnable(bool flg)
		{
			if(this.InvokeRequired)
			{
				WdEnableCallback d = new WdEnableCallback(WdEnable);
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
	}
}
