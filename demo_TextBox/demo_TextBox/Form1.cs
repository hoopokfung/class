using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_TextBox
{
    public partial class Form1 : Form
    {
        private string _FileName = "";  // the fileName
        private bool _IsSaved = true;   // the file is saved or not.
        private void UpdataRowColsInfo()
        {
            int index = textBox1.GetFirstCharIndexOfCurrentLine();//得到当前行第一个字符的索引
            int row = textBox1.GetLineFromCharIndex(index) + 1;//得到当前行的行号,从0开始，习惯是从1开始，所以+1.
            int col = textBox1.SelectionStart - index + 1;//.SelectionStart得到光标所在位置的索引 减去 当前行第一个字符的索引 = 光标所在的列数（从0开始) 
 
            StatusLabelRow.Text = row.ToString() + " 行";
            StatusLabelCols.Text = col.ToString() + " 列";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            UpdataRowColsInfo();
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            UpdataRowColsInfo();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void 状态栏SToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Mi_NewFile(object sender, EventArgs e)
        {

        }

        private void _Click(object sender, EventArgs e)
        {

        }

        private void Mi_NewFile_Click(object sender, EventArgs e)
        {
            DialogResult dResult;
            if (!_IsSaved)
            {
                dResult = MessageBox.Show("当前文件已修改，要保存吗？", "保存提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Yes)
                {
                    if (this.textBox1.Text == "文本文档")
                    {
                        Mi_SaveAs_Click(sender,e);
                    }
                    else
                    {
                        Mi_SaveFile_Click(sender, e);
                    }
                }
                else if (dResult == DialogResult.No)
                {
                    _FileName = "";
                    _IsSaved = true;
                    textBox1.Clear();
                    this.Text = "新建文本文件";
                    textBox1.Focus();
                }
                else
                {
                    _FileName = "";
                    _IsSaved = true;
                    textBox1.Clear();
                    this.Text = "新建文本文件";
                    textBox1.Focus();

                }
            }
        }

        private void Mi_OpenFile_Click(object sender, EventArgs e)
        {
            if ()
        }

        private void Mi_SaveFile_Click(object sender, EventArgs e)
        {

        }

        private void Mi_SaveAs_Click(object sender, EventArgs e)
        {

        }

        private void Mi_PageSetup_Click(object sender, EventArgs e)
        {

        }

        private void Mi_Print_Click(object sender, EventArgs e)
        {

        }

        private void Mi_Exit_Click(object sender, EventArgs e)
        {

        }

        private void Mi_StatusStrip_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            textBox1.WordWrap = ((ToolStripMenuItem)sender).Checked;
        }

        private void mi_AutoLine_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            textBox1.WordWrap = ((ToolStripMenuItem)sender).Checked;
        }
    }
}
