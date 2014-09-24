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
	public class WdPictureBox : System.Windows.Forms.PictureBox
	{
		///////////////////////////////////////////////////////////////////////
		delegate void WdRefreshCallback();
		public void WdRefresh()		// Since Refresh exists, it was referred to as WdRefresh. 
		{
			if (this.InvokeRequired)
			{
				WdRefreshCallback d = new WdRefreshCallback(WdRefresh);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Refresh();
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
