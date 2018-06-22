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

namespace WithDelegate
{
	public class WdListBox : System.Windows.Forms.ListBox
	{
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate int GetCountCallback();
		public int GetCount()
		{
			if(this.InvokeRequired)
			{
				GetCountCallback d = new GetCountCallback(GetCount);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Items.Count;
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate int WdGetCountCallback();
		public int WdGetCount()
		{
			if(this.InvokeRequired)
			{
				WdGetCountCallback d = new WdGetCountCallback(WdGetCount);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Items.Count;
			}
		}
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void ClearCallback();
		public void Clear()
		{
			if(this.InvokeRequired)
			{
				ClearCallback d = new ClearCallback(Clear);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Items.Clear();
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdClearCallback();
		public void WdClear()
		{
			if(this.InvokeRequired)
			{
				WdClearCallback d = new WdClearCallback(WdClear);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Items.Clear();
			}
		}
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void RemoveAtCallback(int index);
		public void RemoveAt(int index)
		{
			if(this.InvokeRequired)
			{
				RemoveAtCallback d = new RemoveAtCallback(RemoveAt);
				this.Invoke(d, new object[] { index });
			}
			else
			{
				this.Items.RemoveAt(index);
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdRemoveAtCallback(int index);
		public void WdRemoveAt(int index)
		{
			if(this.InvokeRequired)
			{
				WdRemoveAtCallback d = new WdRemoveAtCallback(WdRemoveAt);
				this.Invoke(d, new object[] { index });
			}
			else
			{
				this.Items.RemoveAt(index);
			}
		}
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void InsertItemCallback(int index, object item);
		public void InsertItem(int index, object item)
		{
			if(this.InvokeRequired)
			{
				InsertItemCallback d = new InsertItemCallback(InsertItem);
				this.Invoke(d, new object[] { index, item });
			}
			else
			{
				this.Items.Insert(index, item);
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdInsertItemCallback(int index, object item);
		public void WdInsertItem(int index, object item)
		{
			if(this.InvokeRequired)
			{
				WdInsertItemCallback d = new WdInsertItemCallback(WdInsertItem);
				this.Invoke(d, new object[] { index, item });
			}
			else
			{
				this.Items.Insert(index, item);
			}
		}
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate int AddItemCallback(object item);
		public int AddItem(object item)
		{
			if(this.InvokeRequired)
			{
				AddItemCallback d = new AddItemCallback(AddItem);
				return (int)this.Invoke(d, new object[] { item });
			}
			else
			{
				return this.Items.Add(item);
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdSetSelectedValueCallback(object item);
		public void WdSetSelectedValue(object item)
		{
			if(this.InvokeRequired)
			{
				WdSetSelectedValueCallback d = new WdSetSelectedValueCallback(WdSetSelectedValue);
				this.Invoke(d, new object[] { item });
			}
			else
			{
				this.SelectedValue = item;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate object WdGetSelectedValueCallback();
		public object WdGetSelectedValue()
		{
			if(this.InvokeRequired)
			{
				WdGetSelectedValueCallback d = new WdGetSelectedValueCallback(WdGetSelectedValue);
				return this.Invoke(d, new object[] { });
			}
			else
			{
				return this.SelectedValue;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int WdAddItemCallback(object item);
		public int WdAddItem(object item)
		{
			if (this.InvokeRequired)
			{
				WdAddItemCallback d = new WdAddItemCallback(WdAddItem);
				return (int)this.Invoke(d, new object[] { item });
			}
			else
			{
				return this.Items.Add(item);
			}
		}
		////////////////////////////////////////////////////////////////
		delegate object WdGetItemCallback(int index);
		public object WdGetItem(int index)
		{
			if (this.InvokeRequired)
			{
				WdGetItemCallback d = new WdGetItemCallback(WdGetItem);
				return (object)this.Invoke(d, new object[] { index });
			}
			else
			{
				return this.Items[index];
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetSelectIndexCallback(int index);
		public void WdSetSelectIndex(int index)
		{
			if(this.InvokeRequired)
			{
				WdSetSelectIndexCallback d = new WdSetSelectIndexCallback(WdSetSelectIndex);
				this.Invoke(d, new object[] { index });
			}
			else
			{
				this.SelectedIndex = index;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSetTopIndexCallback(int index);
		public void WdSetTopIndex(int index)
		{
			if(this.InvokeRequired)
			{
				WdSetTopIndexCallback d = new WdSetTopIndexCallback(WdSetTopIndex);
				this.Invoke(d, new object[] { index });
			}
			else
			{
				this.TopIndex = index;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int WdGetSelectIndexCallback();
		public int WdGetSelectIndex()
		{
			if(this.InvokeRequired)
			{
				WdGetSelectIndexCallback d = new WdGetSelectIndexCallback(WdGetSelectIndex);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.SelectedIndex;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdInvalidateCallback();
		public void WdInvalidate()
		{
			if(this.InvokeRequired)
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
			if(this.InvokeRequired)
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
		delegate void EnableCallback(bool flg);
		public void Enable(bool flg)
		{
			if(this.InvokeRequired)
			{
				EnableCallback d = new EnableCallback(Enable);
				this.Invoke(d, new object[] { flg });
			}
			else
			{
				this.Enabled = flg;
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdEnableCallback(bool flg);
		public void WdEnable(bool flg)
		{
			if(this.InvokeRequired)
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
