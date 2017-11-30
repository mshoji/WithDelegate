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
	public class WdListView : System.Windows.Forms.ListView
	{
		////////////////////////////////////////////////////////////////
		delegate void WdSetViewCallback(System.Windows.Forms.View view);
		public void WdSetView(System.Windows.Forms.View view)		// Since SetView exists, it was referred to as WdSetView. 
		{
			if (this.InvokeRequired)
			{
				WdSetViewCallback d = new WdSetViewCallback(WdSetView);
				this.Invoke(d, new object[] { view });
			}
			else
			{
				this.View = view;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdColumnsAddCallback(string text);
		public void WdColumnsAdd(string text)		// Since ColumnsAdd exists, it was referred to as WdColumnsAdd. 
		{
			if(this.InvokeRequired)
			{
				WdColumnsAddCallback d = new WdColumnsAddCallback(WdColumnsAdd);
				this.Invoke(d, new object[] { text });
			}
			else
			{
				this.Columns.Add(text);
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdColumnsClearCallback();
		public void WdColumnsClear()		// Since ColumnsAdd exists, it was referred to as WdColumnsAdd. 
		{
			if(this.InvokeRequired)
			{
				WdColumnsClearCallback d = new WdColumnsClearCallback(WdColumnsClear);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Columns.Clear();
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdColumnsAddCallback5(string text, int width, System.Windows.Forms.HorizontalAlignment textAlign);
		public void WdColumnsAdd(string text, int width, System.Windows.Forms.HorizontalAlignment textAlign)
		// Since ColumnsAdd exists, it was referred to as WdColumnsAdd. 
		{
			if (this.InvokeRequired)
			{
				WdColumnsAddCallback5 d = new WdColumnsAddCallback5(WdColumnsAdd);
				this.Invoke(d, new object[] { text, width, textAlign });
			}
			else
			{
				this.Columns.Add(text, width, textAlign);
			}
		}
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate string GetTextCallback(int itemsNum, int subItemsNum);
		public string GetText(int itemsNum, int subItemsNum)
		{
			if(this.InvokeRequired)
			{
				GetTextCallback d = new GetTextCallback(GetText);
				return (string)this.Invoke(d, new object[] { itemsNum, subItemsNum });
			}
			else
			{
				return this.Items[itemsNum].SubItems[subItemsNum].Text;
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate string WdGetTextCallback(int itemsNum, int subItemsNum);
		public string WdGetText(int itemsNum, int subItemsNum)
		{
			if(this.InvokeRequired)
			{
				WdGetTextCallback d = new WdGetTextCallback(WdGetText);
				return (string)this.Invoke(d, new object[] { itemsNum, subItemsNum });
			}
			else
			{
				return this.Items[itemsNum].SubItems[subItemsNum].Text;
			}
		}
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void SetTextCallback(int itemsNum, int subItemsNum, string str);
		public void SetText(int itemsNum, int subItemsNum, string str)
		{
			if(this.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetText);
				this.Invoke(d, new object[] { itemsNum, subItemsNum, str });
			}
			else
			{
				this.Items[itemsNum].SubItems[subItemsNum].Text = str;
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdSetTextCallback(int itemsNum, int subItemsNum, string str);
		public void WdSetText(int itemsNum, int subItemsNum, string str)
		{
			if(this.InvokeRequired)
			{
				WdSetTextCallback d = new WdSetTextCallback(WdSetText);
				this.Invoke(d, new object[] { itemsNum, subItemsNum, str });
			}
			else
			{
				this.Items[itemsNum].SubItems[subItemsNum].Text = str;
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
		delegate void WdItemsAddCallback(System.Windows.Forms.ListViewItem item);
		public void WdItemsAdd(System.Windows.Forms.ListViewItem item)		// Since ItemsAdd exists, it was referred to as WdItemsAdd. 
		{
			if (this.InvokeRequired)
			{
				WdItemsAddCallback d = new WdItemsAddCallback(WdItemsAdd);
				this.Invoke(d, new object[] { item });
			}
			else
			{
				this.Items.Add(item);
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int WdGetSelectedItemsCountCallback();
		public int WdGetSelectedItemsCount()		// Since GetSelectedItemsCount exists, it was referred to as WdGetSelectedItemsCount. 
		{
			if (this.InvokeRequired)
			{
				WdGetSelectedItemsCountCallback d = new WdGetSelectedItemsCountCallback(WdGetSelectedItemsCount);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.SelectedItems.Count;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int WdGetSelectedItemIndexCallback(int index);
		public int WdGetSelectedItemIndex(int index)		// Since GetSelectedItemIndex exists, it was referred to as WdGetSelectedItemIndex. 
		{
			if (this.InvokeRequired)
			{
				WdGetSelectedItemIndexCallback d = new WdGetSelectedItemIndexCallback(WdGetSelectedItemIndex);
				return (int)this.Invoke(d, new object[] { index });
			}
			else
			{
				return this.SelectedItems[index].Index;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdForeColorCallback(int index, Color col);
		public void WdForeColor(int index, Color col)		// Since ForeColor exists, it was referred to as WdForeColor. 
		{
			if (this.InvokeRequired)
			{
				WdForeColorCallback d = new WdForeColorCallback(WdForeColor);
				this.Invoke(d, new object[] { index, col });
			}
			else
			{
				this.Items[index].ForeColor = col;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int WdGetItemsCountCallback();
		public int WdGetItemsCount()		// Since GetItemsCount exists, it was referred to as WdGetItemsCount. 
		{
			if (this.InvokeRequired)
			{
				WdGetItemsCountCallback d = new WdGetItemsCountCallback(WdGetItemsCount);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Items.Count;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdRemoveAtCallback(int index);
		public void WdRemoveAt(int index)		// Since RemoveAt exists, it was referred to as WdRemoveAt. 
		{
			if (this.InvokeRequired)
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
		delegate void WdInsertCallback(int index, string str);
		public void WdInsert(int index, string str)		// Since Insert exists, it was referred to as WdInsert. 
		{
			if (this.InvokeRequired)
			{
				WdInsertCallback d = new WdInsertCallback(WdInsert);
				this.Invoke(d, new object[] { index, str });
			}
			else
			{
				this.Items.Insert(index, str);
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdClearCallback();
		public void WdClear()		// Since RemoveAt exists, it was referred to as WdRemoveAt. 
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
		delegate void WdBeginUpdateCallback();
		public void WdBeginUpdate()
		{
			if (this.InvokeRequired)
			{
				WdBeginUpdateCallback d = new WdBeginUpdateCallback(WdBeginUpdate);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.BeginUpdate();
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdEndUpdateCallback();
		public void WdEndUpdate()
		{
			if (this.InvokeRequired)
			{
				WdEndUpdateCallback d = new WdEndUpdateCallback(WdEndUpdate);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.EndUpdate();
			}
		}
		////////////////////////////////////////////////////////////////
	}
}
