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
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void SetBackColorCallback(Color col);
		public void SetBackColor(Color col)
		{
			if(this.InvokeRequired)
			{
				SetBackColorCallback d = new SetBackColorCallback(SetBackColor);
				this.Invoke(d, new object[] { col });
			}
			else
			{
				this.BackColor = col;
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdSetBackColorCallback(Color col);
		public void WdSetBackColor(Color col)
		{
			if(this.InvokeRequired)
			{
				WdSetBackColorCallback d = new WdSetBackColorCallback(WdSetBackColor);
				this.Invoke(d, new object[] { col });
			}
			else
			{
				this.BackColor = col;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetImageCallback(Image image);
		public void WdSetImage(Image image)
		{
			if (this.InvokeRequired)
			{
				WdSetImageCallback d = new WdSetImageCallback(WdSetImage);
				this.Invoke(d, new object[] { image });
			}
			else
			{
				this.Image = image;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate Image WdGetImageCallback();
		public Image WdGetImage()
		{
			if (this.InvokeRequired)
			{
				WdGetImageCallback d = new WdGetImageCallback(WdGetImage);
				return (Image)this.Invoke(d, new object[] {  });
			}
			else
			{
				return this.Image;
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
		delegate void WdInvalidateCallback();
		public void WdInvalidate()
		{
			if (this.InvokeRequired)
			{
				WdInvalidateCallback d = new WdInvalidateCallback(WdInvalidate);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Invalidate();
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdUpdateCallback();
		public void WdUpdate()
		{
			if (this.InvokeRequired)
			{
				WdUpdateCallback d = new WdUpdateCallback(WdUpdate);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Update();
			}
		}
		////////////////////////////////////////////////////////////////
	}
}
