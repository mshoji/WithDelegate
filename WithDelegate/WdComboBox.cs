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

namespace WithDelegate
{
	public class WdComboBox : System.Windows.Forms.ComboBox
	{
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate string GetTextCallback();
		public string GetText()
		{
			if(this.InvokeRequired)
			{
				GetTextCallback d = new GetTextCallback(GetText);
				return (string)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Text;
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate string WdGetTextCallback();
		public string WdGetText()
		{
			if(this.InvokeRequired)
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void SetTextCallback(string str);
		public void SetText(string str)
		{
			if(this.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetText);
				this.Invoke(d, new object[] { str });
			}
			else
			{
				this.Text = str;
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdSetTextCallback(string str);
		public void WdSetText(string str)
		{
			if(this.InvokeRequired)
			{
				WdSetTextCallback d = new WdSetTextCallback(WdSetText);
				this.Invoke(d, new object[] { str });
			}
			else
			{
				this.Text = str;
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
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void ClearItemsCallback();
		public void ClearItems()
		{
			if(this.InvokeRequired)
			{
				ClearItemsCallback d = new ClearItemsCallback(ClearItems);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Items.Clear();
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdClearItemsCallback();
		public void WdClearItems()
		{
			if(this.InvokeRequired)
			{
				WdClearItemsCallback d = new WdClearItemsCallback(WdClearItems);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Items.Clear();
			}
		}
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void AddStringItemsCallback(string str);
		public void AddStringItems(string str)
		{
			if(this.InvokeRequired)
			{
				AddStringItemsCallback d = new AddStringItemsCallback(AddStringItems);
				this.Invoke(d, new object[] { str });
			}
			else
			{
				this.Items.Add(str);
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdAddStringItemsCallback(string str);
		public void WdAddStringItems(string str)
		{
			if(this.InvokeRequired)
			{
				WdAddStringItemsCallback d = new WdAddStringItemsCallback(WdAddStringItems);
				this.Invoke(d, new object[] { str });
			}
			else
			{
				this.Items.Add(str);
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
        delegate void WdSetSelectIndexCallback(int index);
        public void WdSetSelectIndex(int index)
        {
            if (this.InvokeRequired)
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
        delegate int WdGetSelectIndexCallback();
        public int WdGetSelectIndex()
        {
            if (this.InvokeRequired)
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
		delegate void WdSetSizeCallback(Size size);
		public void WdSetSize(Size size)       // Since SelectionStart exists, it was referred to as WdSelectionStart. 
		{
			if (this.InvokeRequired)
			{
				WdSetSizeCallback d = new WdSetSizeCallback(WdSetSize);
				this.Invoke(d, new object[] { size });
			}
			else
			{
				this.Size = size;
			}
		}
        ////////////////////////////////////////////////////////////////
        delegate int WdGetCountCallback();
        public int WdGetCount()
        {
            if (this.InvokeRequired)
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
        delegate object WdGetItemCallback(int index);
        public object WdGetItem(int index)
        {
            if (this.InvokeRequired)
            {
                WdGetItemCallback d = new WdGetItemCallback(WdGetItem);
                return this.Invoke(d, new object[] { index });
            }
            else
            {
                return this.Items[index];
            }
        }
        ////////////////////////////////////////////////////////////////
        delegate string WdIsItemStrCallback(string str);
        public string WdIsItemStr(string str)
        {
            if (this.InvokeRequired)
            {
                WdIsItemStrCallback d = new WdIsItemStrCallback(WdIsItemStr);
                return (string)this.Invoke(d, new object[] { });
            }
            else
            {
                foreach(object o in this.Items)
                {
                    if (str.CompareTo((string)o) == 0)
                        return str;
                }
                return null;
            }
        }
        ////////////////////////////////////////////////////////////////
	}
}
