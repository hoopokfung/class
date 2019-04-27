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

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 状态栏SToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
