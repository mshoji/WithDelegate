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
	public class WdRichTextBox : System.Windows.Forms.RichTextBox
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
		delegate void WdAppendTextCallback(string str);
		public void WdAppendText(string str)		// Since AppendText exists, it was referred to as WdAppendText. 
		{
			if (this.InvokeRequired)
			{
				WdAppendTextCallback d = new WdAppendTextCallback(WdAppendText);
				this.Invoke(d, new object[] { str });
			}
			else
			{
				this.AppendText(str);
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
		delegate void WdScrollToCaretCallback();
		public void WdScrollToCaret()		// Since ScrollToCaret exists, it was referred to as WdScrollToCaret. 
		{
			if (this.InvokeRequired)
			{
				WdScrollToCaretCallback d = new WdScrollToCaretCallback(WdScrollToCaret);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.ScrollToCaret();
			}
		}
		////////////////////////////////////////////////////////////////
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
		delegate void WdSelectCallback();
		public void WdSelect()		// Since Select exists, it was referred to as WdSelect. 
		{
			if (this.InvokeRequired)
			{
				WdSelectCallback d = new WdSelectCallback(WdSelect);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.Select();
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSelectAllCallback();
		public void WdSelectAll()		// Since SelectAll exists, it was referred to as WdSelectAll. 
		{
			if (this.InvokeRequired)
			{
				WdSelectAllCallback d = new WdSelectAllCallback(WdSelectAll);
				this.Invoke(d, new object[] { });
			}
			else
			{
				this.SelectAll();
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSelectionColorCallback(Color col);
		public void WdSelectionColor(Color col)		// Since SelectionColor exists, it was referred to as WdSelectionColor. 
		{
			if (this.InvokeRequired)
			{
				WdSelectionColorCallback d = new WdSelectionColorCallback(WdSelectionColor);
				this.Invoke(d, new object[] { col });
			}
			else
			{
				this.SelectionColor = col;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSelectionLengthCallback(int length);
		public void WdSelectionLength(int length)		// Since SelectionLength exists, it was referred to as WdSelectionLength. 
		{
			if (this.InvokeRequired)
			{
				WdSelectionLengthCallback d = new WdSelectionLengthCallback(WdSelectionLength);
				this.Invoke(d, new object[] { length });
			}
			else
			{
				this.SelectionLength = length;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSelectionFontCallback(Font font);
		public void WdSelectionFont(Font font)		// Since SelectionFont exists, it was referred to as WdSelectionFont. 
		{
			if (this.InvokeRequired)
			{
				WdSelectionFontCallback d = new WdSelectionFontCallback(WdSelectionFont);
				this.Invoke(d, new object[] { font });
			}
			else
			{
				this.SelectionFont = font;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSelectedTextCallback(string text);
		public void WdSelectedText(string text)		// Since SelectedText exists, it was referred to as WdSelectedText. 
		{
			if (this.InvokeRequired)
			{
				WdSelectedTextCallback d = new WdSelectedTextCallback(WdSelectedText);
				this.Invoke(d, new object[] { text });
			}
			else
			{
				this.SelectedText = text;
			}
		}
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate int GetLinesLengthCallback();
		public int GetLinesLength()
		{
			if(this.InvokeRequired)
			{
				GetLinesLengthCallback d = new GetLinesLengthCallback(GetLinesLength);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Lines.Length;
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate int WdGetLinesLengthCallback();
		public int WdGetLinesLength()
		{
			if(this.InvokeRequired)
			{
				WdGetLinesLengthCallback d = new WdGetLinesLengthCallback(WdGetLinesLength);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Lines.Length;
			}
		}
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void RemoveFirstLineCallback();
		public void RemoveFirstLine()		// The information on a color will disappear. (???)
		{
			if(this.InvokeRequired)
			{
				RemoveFirstLineCallback d = new RemoveFirstLineCallback(RemoveFirstLine);
				this.Invoke(d, new object[] { });
			}
			else
			{
				int index = this.GetFirstCharIndexFromLine(1);
				this.Select(0, index >= 0 ? index : this.TextLength);
				this.SelectedText = "";
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdRemoveFirstLineCallback();
		public void WdRemoveFirstLine()		// The information on a color will disappear. (???)
		{
			if(this.InvokeRequired)
			{
				WdRemoveFirstLineCallback d = new WdRemoveFirstLineCallback(WdRemoveFirstLine);
				this.Invoke(d, new object[] { });
			}
			else
			{
				int index = this.GetFirstCharIndexFromLine(1);
				this.Select(0, index >= 0 ? index : this.TextLength);
				this.SelectedText = "";
			}
		}
		////////////////////////////////////////////////////////////////
#if false	// 旧バージョンとの互換性維持のために残すかもしれない
		delegate void RemoveLineCallback(int num);
		public void RemoveLine(int num)		// The information on a color will disappear. (???)
		{
			if(this.InvokeRequired)
			{
				RemoveLineCallback d = new RemoveLineCallback(RemoveLine);
				this.Invoke(d, new object[] { num });
			}
			else
			{
				int start_index = this.GetFirstCharIndexFromLine(num);
				int count = this.Lines[num].Length;

				// Eat new line chars
				if(num < this.Lines.Length - 1)
				{
					count += this.GetFirstCharIndexFromLine(num + 1) -
						((start_index + count - 1) + 1);
				}

				this.Text = this.Text.Remove(start_index, count);
			}
		}
#endif
		////////////////////////////////////////////////////////////////
		delegate void WdRemoveLineCallback(int num);
		public void WdRemoveLine(int num)		// The information on a color will disappear. (???)
		{
			if(this.InvokeRequired)
			{
				WdRemoveLineCallback d = new WdRemoveLineCallback(WdRemoveLine);
				this.Invoke(d, new object[] { num });
			}
			else
			{
				int start_index = this.GetFirstCharIndexFromLine(num);
				int count = this.Lines[num].Length;

				// Eat new line chars
				if(num < this.Lines.Length - 1)
				{
					count += this.GetFirstCharIndexFromLine(num + 1) -
						((start_index + count - 1) + 1);
				}

				this.Text = this.Text.Remove(start_index, count);
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void WdSelectionStartCallback(int val);
		public void WdSelectionStart(int val)		// Since SelectionStart exists, it was referred to as WdSelectionStart. 
		{
			if (this.InvokeRequired)
			{
				WdSelectionStartCallback d = new WdSelectionStartCallback(WdSelectionStart);
				this.Invoke(d, new object[] { val });
			}
			else
			{
				this.SelectionStart = val;
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
