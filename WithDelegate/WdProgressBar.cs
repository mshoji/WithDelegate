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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void SetMaximumCallback(int val);
		public void SetMaximum(int val)
		{
			if(this.InvokeRequired)
			{
				SetMaximumCallback d = new SetMaximumCallback(SetMaximum);
				this.Invoke(d, new object[] { val });
			}
			else
			{
				this.Maximum = val;
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdSetMaximumCallback(int val);
		public void WdSetMaximum(int val)
		{
			if(this.InvokeRequired)
			{
				WdSetMaximumCallback d = new WdSetMaximumCallback(WdSetMaximum);
				this.Invoke(d, new object[] { val });
			}
			else
			{
				this.Maximum = val;
			}
		}
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void SetMinimumCallback(int val);
		public void SetMinimum(int val)
		{
			if(this.InvokeRequired)
			{
				SetMinimumCallback d = new SetMinimumCallback(SetMinimum);
				this.Invoke(d, new object[] { val });
			}
			else
			{
				this.Minimum = val;
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdSetMinimumCallback(int val);
		public void WdSetMinimum(int val)
		{
			if(this.InvokeRequired)
			{
				WdSetMinimumCallback d = new WdSetMinimumCallback(WdSetMinimum);
				this.Invoke(d, new object[] { val });
			}
			else
			{
				this.Minimum = val;
			}
		}
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void SetValueCallback(int val);
		public void SetValue(int val)
		{
			if(this.InvokeRequired)
			{
				SetValueCallback d = new SetValueCallback(SetValue);
				this.Invoke(d, new object[] { val });
			}
			else
			{
				this.Value = val;
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdSetValueCallback(int val);
		public void WdSetValue(int val)
		{
			if(this.InvokeRequired)
			{
				WdSetValueCallback d = new WdSetValueCallback(WdSetValue);
				this.Invoke(d, new object[] { val });
			}
			else
			{
				this.Value = val;
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
	}
}
