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

namespace WithDelegate
{
	public class WdComboBox : System.Windows.Forms.ComboBox
	{
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
		delegate void ClearItemsCallback();
		public void ClearItems()
		{
			if (this.InvokeRequired)
			{
				ClearItemsCallback d = new ClearItemsCallback(ClearItems);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Items.Clear();
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void AddStringItemsCallback(string str);
		public void AddStringItems(string str)
		{
			if (this.InvokeRequired)
			{
				AddStringItemsCallback d = new AddStringItemsCallback(AddStringItems);
				this.Invoke(d, new object[] { str });
			}
			else
			{
				this.Items.Add(str);
			}
		}
	}
}
