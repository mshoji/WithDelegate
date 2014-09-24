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
	public class WdListBox : System.Windows.Forms.ListBox
	{
		////////////////////////////////////////////////////////////////
		delegate int GetCountCallback();
		public int GetCount()
		{
			if (this.InvokeRequired)
			{
				GetCountCallback d = new GetCountCallback(GetCount);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Items.Count;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void ClearCallback();
		public void Clear()
		{
			if (this.InvokeRequired)
			{
				ClearCallback d = new ClearCallback(Clear);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Items.Clear();
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void RemoveAtCallback(int index);
		public void RemoveAt(int index)
		{
			if (this.InvokeRequired)
			{
				RemoveAtCallback d = new RemoveAtCallback(RemoveAt);
				this.Invoke(d, new object[] { index });
			}
			else
			{
				this.Items.RemoveAt(index);
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void InsertItemCallback(int index, object item);
		public void InsertItem(int index, object item)
		{
			if (this.InvokeRequired)
			{
				InsertItemCallback d = new InsertItemCallback(InsertItem);
				this.Invoke(d, new object[] { index, item });
			}
			else
			{
				this.Items.Insert(index, item);
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int AddItemCallback(object item);
		public int AddItem(object item)
		{
			if (this.InvokeRequired)
			{
				AddItemCallback d = new AddItemCallback(AddItem);
				return (int)this.Invoke(d, new object[] { item });
			}
			else
			{
				return this.Items.Add(item);
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
	}
}
