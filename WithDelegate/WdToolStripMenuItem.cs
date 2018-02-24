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
    }
}
