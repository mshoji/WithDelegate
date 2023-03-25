using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WithDelegate
{
    public class WdDataGridView : System.Windows.Forms.DataGridView
    {
        ///////////////////////////////////////////////////////////////////////
        delegate void WdSetForeColorCallback(Color col);
        public void WdSetForeColor(Color col)
        {
            if (this.InvokeRequired)
            {
                WdSetForeColorCallback d = new WdSetForeColorCallback(WdSetForeColor);
                this.Invoke(d, new object[] { col });
            }
            else
            {
                this.ForeColor = col;
            }
        }
        ///////////////////////////////////////////////////////////////////////
        delegate void WdSetBackColorCallback(Color col);
        public void WdSetBackColor(Color col)
        {
            if (this.InvokeRequired)
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
        delegate string WdGetTextCallback();
        public string WdGetText()
        {
            if (this.InvokeRequired)
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
        delegate void WdSetTextCallback(string str);
        public void WdSetText(string str)
        {
            if (this.InvokeRequired)
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
        delegate void WdVisibleCallback(bool flg);
        public void WdVisible(bool flg)
        {
            if (this.InvokeRequired)
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
        delegate void WdEnableCallback(bool flg);
        public void WdEnable(bool flg)
        {
            if (this.InvokeRequired)
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
#if false
        ////////////////////////////////////////////////////////////////
        delegate DataGridViewColumnCollection WdColumnsCallback();
        public DataGridViewColumnCollection WdColumns()
        {
            if (this.InvokeRequired)
            {
                WdColumnsCallback d = new WdColumnsCallback(WdColumns);
                return (DataGridViewColumnCollection)this.Invoke(d, new object[] { });
            }
            else
            {
                return this.Columns;
            }
        }
        ////////////////////////////////////////////////////////////////
        delegate DataGridViewRowCollection WdRowsCallback();
        public DataGridViewRowCollection WdRows()
        {
            if (this.InvokeRequired)
            {
                WdRowsCallback d = new WdRowsCallback(WdRows);
                return (DataGridViewRowCollection)this.Invoke(d, new object[] { });
            }
            else
            {
                return this.Rows;
            }
        }
#endif
        ////////////////////////////////////////////////////////////////
        delegate int WdGetColumnCountCallback();
        public int WdGetColumnCount()
        {
            if (this.InvokeRequired)
            {
                WdGetColumnCountCallback d = new WdGetColumnCountCallback(WdGetColumnCount);
                return (int)this.Invoke(d, new object[] { });
            }
            else
            {
                return this.ColumnCount;
            }
        }
        ////////////////////////////////////////////////////////////////
        delegate void WdSetColumnCountCallback(int count);
        public void WdSetColumnCount(int count)
        {
            if (this.InvokeRequired)
            {
                WdSetColumnCountCallback d = new WdSetColumnCountCallback(WdSetColumnCount);
                this.Invoke(d, new object[] { count });
            }
            else
            {
                this.ColumnCount = count;
            }
        }
        ////////////////////////////////////////////////////////////////
        delegate void WdSetColumnHeaderTextCallback(int offset, string str);
        public void WdSetColumnHeaderText(int offset, string str)
        {
            if (this.InvokeRequired)
            {
                WdSetColumnHeaderTextCallback d = new WdSetColumnHeaderTextCallback(WdSetColumnHeaderText);
                this.Invoke(d, new object[] { offset, str });
            }
            else
            {
                this.Columns[offset].HeaderText = str;
            }
        }
        ////////////////////////////////////////////////////////////////
        delegate string WdGetColumnHeaderTextCallback(int offset);
        public string WdGetColumnHeaderText(int offset)
        {
            if (this.InvokeRequired)
            {
                WdGetColumnHeaderTextCallback d = new WdGetColumnHeaderTextCallback(WdGetColumnHeaderText);
                return (string)this.Invoke(d, new object[] { offset });
            }
            else
            {
                return this.Columns[offset].HeaderText;
            }
        }
        ////////////////////////////////////////////////////////////////
        delegate void WdRowsAddCallback1(params object[] obj);
        public void WdRowsAdd(params object[] obj)
        {
            if (this.InvokeRequired)
            {
                WdRowsAddCallback1 d = new WdRowsAddCallback1(WdRowsAdd);
                this.Invoke(d, new object[] { obj });
            }
            else
            {
                this.Rows.Add(obj);
            }
        }
        ////////////////////////////////////////////////////////////////
        delegate void WdRowsAddCallback2(DataGridViewRow dataGridViewRow);
        public void WdRowsAdd(DataGridViewRow dataGridViewRow)
        {
            if (this.InvokeRequired)
            {
                WdRowsAddCallback2 d = new WdRowsAddCallback2(WdRowsAdd);
                this.Invoke(d, new object[] { dataGridViewRow });
            }
            else
            {
                this.Rows.Add(dataGridViewRow);
            }
        }
        ////////////////////////////////////////////////////////////////
        delegate void WdRowsAddCallback3(int count);
        public void WdRowsAdd(int count)
        {
            if (this.InvokeRequired)
            {
                WdRowsAddCallback3 d = new WdRowsAddCallback3(WdRowsAdd);
                this.Invoke(d, new object[] { count });
            }
            else
            {
                this.Rows.Add(count);
            }
        }
        ////////////////////////////////////////////////////////////////
        delegate void WdRowsAddCallback4();
        public void WdRowsAdd()
        {
            if (this.InvokeRequired)
            {
                WdRowsAddCallback4 d = new WdRowsAddCallback4(WdRowsAdd);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.Rows.Add();
            }
        }
        ////////////////////////////////////////////////////////////////
        delegate void WdSetRowsCellsValueCallback(int offsetRow, int offsetCell, object value);
        public void WdSetRowsCellsValue(int offsetRow, int offsetCell, object value)
        {
            if (this.InvokeRequired)
            {
                WdSetRowsCellsValueCallback d = new WdSetRowsCellsValueCallback(WdSetRowsCellsValue);
                this.Invoke(d, new object[] { offsetRow, offsetCell, value });
            }
            else
            {
                this.Rows[offsetRow].Cells[offsetCell].Value = value;
            }
        }
        ////////////////////////////////////////////////////////////////
        delegate object WdGetRowsCellsValueCallback(int offsetRow, int offsetCell);
        public object WdGetRowsCellsValue(int offsetRow, int offsetCell)
        {
            if (this.InvokeRequired)
            {
                WdGetRowsCellsValueCallback d = new WdGetRowsCellsValueCallback(WdGetRowsCellsValue);
                return (object)this.Invoke(d, new object[] { offsetRow, offsetCell});
            }
            else
            {
                return this.Rows[offsetRow].Cells[offsetCell].Value;
            }
        }
        ////////////////////////////////////////////////////////////////
    }
}
