﻿/**
WithDelegate

Copyright (c) 2012 Masahiko SHOJI

This software is released under the MIT License.

http://opensource.org/licenses/mit-license.php

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WithDelegate
{
	public class WdDateTimePicker : System.Windows.Forms.DateTimePicker
	{
		////////////////////////////////////////////////////////////////
		delegate void ThisWdVisibleCallback(bool flg);
		public void WdVisible(bool flg)
		{
			if(this.InvokeRequired)
			{
				ThisWdVisibleCallback d = new ThisWdVisibleCallback(WdVisible);
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
		delegate DateTime WdGetValueCallback();
		public DateTime WdGetValue()
		{
			if (this.InvokeRequired)
			{
				WdGetValueCallback d = new WdGetValueCallback(WdGetValue);
				return (DateTime)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Value;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate DateTime WdSetValueCallback(DateTime dt);
		public DateTime WdSetValue(DateTime dt)
		{
			if (this.InvokeRequired)
			{
				WdSetValueCallback d = new WdSetValueCallback(WdSetValue);
				return (DateTime)this.Invoke(d, new object[] {dt});
			}
			else
			{
				return this.Value = dt;
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
    }
}
