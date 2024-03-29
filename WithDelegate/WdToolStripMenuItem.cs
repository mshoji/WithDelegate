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
using System.Windows.Forms;

namespace WithDelegate
{
    public class WdToolStripMenuItem : System.Windows.Forms.ToolStripMenuItem
    {
        ////////////////////////////////////////////////////////////////
        delegate void WdVisibleCallback(bool flg);
        public void WdVisible(bool flg)
        {
            System.Windows.Forms.ToolStrip toolStrip = this.GetCurrentParent();
            if (toolStrip.InvokeRequired)
            {
                WdVisibleCallback d = new WdVisibleCallback(WdVisible);
                toolStrip.Invoke(d, new object[] { flg });
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
            System.Windows.Forms.ToolStrip toolStrip = this.GetCurrentParent();
            if (toolStrip.InvokeRequired)
            {
                WdEnableCallback d = new WdEnableCallback(WdEnable);
                toolStrip.Invoke(d, new object[] { flg });
            }
            else
            {
                this.Enabled = flg;
            }
        }
		////////////////////////////////////////////////////////////////
		delegate void WdSetSizeCallback(Size size);
		public void WdSetSize(Size size)       // Since SelectionStart exists, it was referred to as WdSelectionStart. 
		{
			System.Windows.Forms.ToolStrip toolStrip = this.GetCurrentParent();
			if (toolStrip.InvokeRequired)
			{
				WdSetSizeCallback d = new WdSetSizeCallback(WdSetSize);
				toolStrip.Invoke(d, new object[] { size });
			}
			else
			{
				this.Size = size;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetCheckCallback(bool flg);
		public void WdSetCheck(bool flg)
		{
			System.Windows.Forms.ToolStrip toolStrip = this.GetCurrentParent();
			if(toolStrip.InvokeRequired)
			{
				WdSetCheckCallback d = new WdSetCheckCallback(WdSetCheck);
				toolStrip.Invoke(d, new object[] { flg });
			}
			else
			{
				this.Checked = flg;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate bool WdGetCheckCallback();
		public bool WdGetCheck()
		{
			System.Windows.Forms.ToolStrip toolStrip = this.GetCurrentParent();
			if(toolStrip.InvokeRequired)
			{
				WdGetCheckCallback d = new WdGetCheckCallback(WdGetCheck);
				return (bool)toolStrip.Invoke(d, new object[] { });
			}
			else
			{
				return this.Checked;
			}
		}
		////////////////////////////////////////////////////////////////
	}
}
