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
	public class WdProgressBar : System.Windows.Forms.ProgressBar
	{
		////////////////////////////////////////////////////////////////
		delegate void SetMaximumCallback(int val);
		public void SetMaximum(int val)
		{
			if (this.InvokeRequired)
			{
				SetMaximumCallback d = new SetMaximumCallback(SetMaximum);
				this.Invoke(d, new object[] { val });
			}
			else
			{
				this.Maximum = val;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void SetMinimumCallback(int val);
		public void SetMinimum(int val)
		{
			if (this.InvokeRequired)
			{
				SetMinimumCallback d = new SetMinimumCallback(SetMinimum);
				this.Invoke(d, new object[] { val });
			}
			else
			{
				this.Minimum = val;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void SetValueCallback(int val);
		public void SetValue(int val)
		{
			if (this.InvokeRequired)
			{
				SetValueCallback d = new SetValueCallback(SetValue);
				this.Invoke(d, new object[] { val });
			}
			else
			{
				this.Value = val;
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
	}
}
