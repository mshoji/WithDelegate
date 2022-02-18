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
using System.Drawing;

namespace WithDelegate
{
    public class WdTableLayoutPanel : System.Windows.Forms.RichTextBox
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
        delegate void WdAppendTextCallback(string str);
        public void WdAppendText(string str)		// Since AppendText exists, it was referred to as WdAppendText. 
        {
            if (this.InvokeRequired)
            {
                WdAppendTextCallback d = new WdAppendTextCallback(WdAppendText);
                this.Invoke(d, new object[] { str });
            }
            else
            {
                this.AppendText(str);
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
        ////////////////////////////////////////////////////////////////
    }
}
