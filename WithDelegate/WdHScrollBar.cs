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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate Rectangle GetWdBoundsCallback();
		public Rectangle GetWdBounds()
		{
			if(this.InvokeRequired)
			{
				GetWdBoundsCallback d = new GetWdBoundsCallback(GetWdBounds);
				return (Rectangle)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Bounds;
			}
		}
#endif
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void SetWdBoundsCallback(int x, int y, int width, int height, BoundsSpecified boundsSpecified);
		public void SetWdBounds(int x, int y, int width, int height, BoundsSpecified boundsSpecified)
		{
			if(this.InvokeRequired)
			{
				SetWdBoundsCallback d = new SetWdBoundsCallback(SetWdBounds);
				this.Invoke(d, new object[] { x, y, width, height, boundsSpecified });
			}
			else
			{
				this.SetBounds(x, y, width, height, boundsSpecified);
			}
		}
#endif
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate int GetValueCallback();
		public int GetValue()
		{
			if(this.InvokeRequired)
			{
				GetValueCallback d = new GetValueCallback(GetValue);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Value;
			}
		}
#endif
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void SetValueCallback(int data);
		public void SetValue(int data)
		{
			if(this.InvokeRequired)
			{
				SetValueCallback d = new SetValueCallback(SetValue);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Value = data;
			}
		}
#endif
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate int GetMinimumCallback();
		public int GetMinimum()
		{
			if(this.InvokeRequired)
			{
				GetMinimumCallback d = new GetMinimumCallback(GetMinimum);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Minimum;
			}
		}
#endif
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void SetMinimumCallback(int data);
		public void SetMinimum(int data)
		{
			if(this.InvokeRequired)
			{
				SetMinimumCallback d = new SetMinimumCallback(SetMinimum);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Minimum = data;
			}
		}
#endif
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate int GetMaximumCallback();
		public int GetMaximum()
		{
			if(this.InvokeRequired)
			{
				GetMaximumCallback d = new GetMaximumCallback(GetMaximum);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Maximum;
			}
		}
#endif
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void SetMaximumCallback(int data);
		public void SetMaximum(int data)
		{
			if(this.InvokeRequired)
			{
				SetMaximumCallback d = new SetMaximumCallback(SetMaximum);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Maximum = data;
			}
		}
#endif
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate int GetHeightCallback();
		public int GetHeight()
		{
			if(this.InvokeRequired)
			{
				GetHeightCallback d = new GetHeightCallback(GetHeight);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Height;
			}
		}
#endif
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void SetHeightCallback(int data);
		public void SetHeight(int data)
		{
			if(this.InvokeRequired)
			{
				SetHeightCallback d = new SetHeightCallback(SetHeight);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Height = data;
			}
		}
#endif
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate int GetWidthCallback();
		public int GetWidth()
		{
			if(this.InvokeRequired)
			{
				GetWidthCallback d = new GetWidthCallback(GetWidth);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Width;
			}
		}
#endif
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void SetWidthCallback(int data);
		public void SetWidth(int data)
		{
			if(this.InvokeRequired)
			{
				SetWidthCallback d = new SetWidthCallback(SetWidth);
				this.Invoke(d, new object[] { data });
			}
			else
			{
				this.Width = data;
			}
		}
#endif
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate string GetTextCallback();
		public string GetText()
		{
			if(this.InvokeRequired)
			{
				GetTextCallback d = new GetTextCallback(GetText);
				return (string)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Text;
			}
		}
#endif
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void SetTextCallback(string str);
		public void SetText(string str)
		{
			if(this.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetText);
				this.Invoke(d, new object[] { str });
			}
			else
			{
				this.Text = str;
			}
		}
#endif
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void EnableCallback(bool flg);
		public void Enable(bool flg)
		{
			if(this.InvokeRequired)
			{
				EnableCallback d = new EnableCallback(Enable);
				this.Invoke(d, new object[] { flg });
			}
			else
			{
				this.Enabled = flg;
			}
		}
#endif
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
	}
}
