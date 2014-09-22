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
	public class WdCheckBox : System.Windows.Forms.CheckBox
	{
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
		delegate void SetCheckCallback(bool flg);
		public void SetCheck(bool flg)
		{
			if (this.InvokeRequired)
			{
				SetCheckCallback d = new SetCheckCallback(SetCheck);
				this.Invoke(d, new object[] { flg });
			}
			else
			{
				this.Checked = flg;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate bool GetCheckCallback();
		public bool GetCheck()
		{
			if (this.InvokeRequired)
			{
				GetCheckCallback d = new GetCheckCallback(GetCheck);
				return (bool)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Checked;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void EnableCallback(bool flg);
		public void Enable(bool flg)
		{
			if (this.InvokeRequired)
			{
				EnableCallback d = new EnableCallback(Enable);
				this.Invoke(d, new object[] { flg });
			}
			else
			{
				this.Enabled = flg;
			}
		}
	}
}
