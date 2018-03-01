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
	public class WdNumericUpDown : System.Windows.Forms.NumericUpDown
	{
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }
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
		delegate decimal WdGetValueCallback();
		public decimal WdGetValue()
		{
			if (this.InvokeRequired)
			{
				WdGetValueCallback d = new WdGetValueCallback(WdGetValue);
				return (decimal)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Value;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetValueCallback(decimal data);
		public void WdSetValue(decimal data)
		{
			if (this.InvokeRequired)
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
		delegate decimal WdGetMinimumCallback();
		public decimal WdGetMinimum()
		{
			if (this.InvokeRequired)
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
		delegate void WdSetMinimumCallback(decimal data);
		public void WdSetMinimum(decimal data)
		{
			if (this.InvokeRequired)
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
		delegate decimal WdGetMaximumCallback();
		public decimal WdGetMaximum()
		{
			if (this.InvokeRequired)
			{
				WdGetMaximumCallback d = new WdGetMaximumCallback(WdGetMaximum);
				return (decimal)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Maximum;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetMaximumCallback(decimal data);
		public void WdSetMaximum(decimal data)
		{
			if (this.InvokeRequired)
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
