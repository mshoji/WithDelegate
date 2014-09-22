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
		delegate string GetTextCallback();
		public string GetText()
		{
			if (this.InvokeRequired)
			{
				GetTextCallback d = new GetTextCallback(GetText);
				return (string)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Text;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void SetTextCallback(string str);
		public void SetText(string str)
		{
			if (this.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetText);
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
		////////////////////////////////////////////////////////////////
		delegate void WdFocusCallback();
		public void WdFocus()		// Since Focus exists, it was referred to as WdFocus. 
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
		delegate void SelectionColorCallback(Color col);
		public void WdSelectionColor(Color col)		// Since SelectionColor exists, it was referred to as WdSelectionColor. 
		{
			if (this.InvokeRequired)
			{
				SelectionColorCallback d = new SelectionColorCallback(WdSelectionColor);
				this.Invoke(d, new object[] { col });
			}
			else
			{
				this.SelectionColor = col;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void SelectionLengthCallback(int length);
		public void WdSelectionLength(int length)		// Since SelectionLength exists, it was referred to as WdSelectionLength. 
		{
			if (this.InvokeRequired)
			{
				SelectionLengthCallback d = new SelectionLengthCallback(WdSelectionLength);
				this.Invoke(d, new object[] { length });
			}
			else
			{
				this.SelectionLength = length;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void SelectionFontCallback(Font font);
		public void WdSelectionFont(Font font)		// Since SelectionFont exists, it was referred to as WdSelectionFont. 
		{
			if (this.InvokeRequired)
			{
				SelectionFontCallback d = new SelectionFontCallback(WdSelectionFont);
				this.Invoke(d, new object[] { font });
			}
			else
			{
				this.SelectionFont = font;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void SelectedTextCallback(string text);
		public void WdSelectedText(string text)		// Since SelectedText exists, it was referred to as WdSelectedText. 
		{
			if (this.InvokeRequired)
			{
				SelectedTextCallback d = new SelectedTextCallback(WdSelectedText);
				this.Invoke(d, new object[] { text });
			}
			else
			{
				this.SelectedText = text;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate int GetLinesLengthCallback();
		public int GetLinesLength()
		{
			if (this.InvokeRequired)
			{
				GetLinesLengthCallback d = new GetLinesLengthCallback(GetLinesLength);
				return (int)this.Invoke(d, new object[] { });
			}
			else
			{
				return this.Lines.Length;
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void RemoveFirstLineCallback();
		public void RemoveFirstLine()		// The information on a color will disappear. (???)
		{
			if (this.InvokeRequired)
			{
				RemoveFirstLineCallback d = new RemoveFirstLineCallback(RemoveFirstLine);
				this.Invoke(d, new object[] { });
			}
			else
			{
#if true
				int index = this.GetFirstCharIndexFromLine(1);
				this.Select(0, index >= 0 ? index : this.TextLength);
				this.SelectedText = "";
#else
				int index = this.Text.IndexOf('\n', 0);
				this.Select(0, index + 1);
				this.SelectedText = "";
#endif
			}
		}
		////////////////////////////////////////////////////////////////
		delegate void RemoveLineCallback(int num);
		public void RemoveLine(int num)		// The information on a color will disappear. (???)
		{
			if (this.InvokeRequired)
			{
				RemoveLineCallback d = new RemoveLineCallback(RemoveLine);
				this.Invoke(d, new object[] { num });
			}
			else
			{
				int start_index = this.GetFirstCharIndexFromLine(num);
				int count = this.Lines[num].Length;

				// Eat new line chars
				if (num < this.Lines.Length - 1)
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
#if false
		delegate void WdIsReadOnlyCaretVisibleCallback(bool flg);
		public void WdIsReadOnlyCaretVisible(bool flg)
		{
			if (this.InvokeRequired)
			{
				WdIsReadOnlyCaretVisibleCallback d = new WdIsReadOnlyCaretVisibleCallback(WdIsReadOnlyCaretVisible);
				this.Invoke(d, new object[] { flg });
			}
			else
			{
				this.IsReadOnlyCaretVisible = flg;
			}
		}
#endif
	}
}
