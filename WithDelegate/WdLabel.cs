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
	public class WdLabel : System.Windows.Forms.Label
	{
		///////////////////////////////////////////////////////////////////////
		delegate void SetForeColorCallback(Color col);
		public void SetForeColor(Color col)
		{
			if (this.InvokeRequired)
			{
				SetForeColorCallback d = new SetForeColorCallback(SetForeColor);
				this.Invoke(d, new object[] { col });
			}
			else
			{
				this.ForeColor = col;
			}
		}
		///////////////////////////////////////////////////////////////////////
		delegate void SetBackColorCallback(Color col);
		public void SetBackColor(Color col)
		{
			if (this.InvokeRequired)
			{
				SetBackColorCallback d = new SetBackColorCallback(SetBackColor);
				this.Invoke(d, new object[] { col });
			}
			else
			{
				this.BackColor = col;
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
	}
}
