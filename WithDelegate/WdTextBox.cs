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

namespace WithDelegate
{
	public class WdTextBox : System.Windows.Forms.TextBox
	{
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
		delegate void WdSelectCallback();
		public void WdSelect()		// Since Select exists, it was referred to as WdSelect. 
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
        ////////////////////////////////////////////////////////////////
        delegate void WdSelectAllCallback();
        public void WdSelectAll()       // Since SelectAll exists, it was referred to as WdSelectAll. 
        {
            if (this.InvokeRequired)
            {
                WdSelectAllCallback d = new WdSelectAllCallback(WdSelectAll);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.SelectAll();
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
		delegate void WdSetBackColorCallback(Color BackColor);
		public void WdSetBackColor(Color BackColor)
		{
			if(this.InvokeRequired)
			{
				WdSetBackColorCallback d = new WdSetBackColorCallback(WdSetBackColor);
				this.Invoke(d, new object[] { BackColor });
			}
			else
			{
				this.BackColor = BackColor;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetForeColorCallback(Color ForeColor);
		public void WdSetForeColor(Color ForeColor)
		{
			if(this.InvokeRequired)
			{
				WdSetForeColorCallback d = new WdSetForeColorCallback(WdSetForeColor);
				this.Invoke(d, new object[] { ForeColor });
			}
			else
			{
				this.ForeColor= ForeColor;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate Color WdGetBackColorCallback();
		public Color WdGetBackColor()
		{
			if(this.InvokeRequired)
			{
				WdGetBackColorCallback d = new WdGetBackColorCallback(WdGetBackColor);
				return (Color)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.BackColor;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate Color WdGetForeColorCallback();
		public Color WdGetForeColor()
		{
			if(this.InvokeRequired)
			{
				WdGetForeColorCallback d = new WdGetForeColorCallback(WdGetForeColor);
				return (Color)this.Invoke(d, new object[] {  });
			}
			else
			{
				return this.ForeColor;
			}
		}
		////////////////////////////////////////////////////////////////

	}
}
