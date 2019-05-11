using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace demo_TextBox
{
    public partial class Form1 : Form
    {
        private string _FileName = "";  // the fileName
        private bool _IsSaved = true;   // the file is saved or not.

        private void SaveTextFile(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine(textBox1.Text);
            sw.Flush();        // 文件流
            sw.Close();         // 最后要关闭写入状态
            _IsSaved = true;
            this.Text = _FileName;
        }
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr;
                sr = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.UTF8);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                _FileName = openFileDialog1.FileName;
                this.Text = _FileName;
                _IsSaved = true;
            }
        }

        private void Mi_SaveFile_Click(object sender, EventArgs e)
        {
            if (_FileName=="")
            {
                Mi_SaveAs_Click(sender, e);
            }
            else
            {
                SaveTextFile(_FileName);
            }
        }

        private void Mi_SaveAs_Click(object sender, EventArgs e)
        {
            if (_FileName == "")
            {
                _FileName = this.Text;

                saveFileDialog1.FileName = _FileName;
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _FileName = saveFileDialog1.FileName;
                    SaveTextFile(_FileName);
                }
            }
        }

        private void Mi_PageSetup_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDialog1.Document.DefaultPageSettings = pageSetupDialog1.Document.DefaultPageSettings;
            }
        }

        private void Mi_Print_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog()==DialogResult.OK)
            {
                printDialog1.Document.Print();
            }
        }

        private void Mi_Exit_Click(object sender, EventArgs e)
        {
            if(!_IsSaved)
            {
                DialogResult dr = MessageBox.Show("文档内容已修改，要保存吗？", "保存提示",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                switch(dr)
                {
                    case DialogResult.Yes:
                        Mi_SaveFile_Click(sender, e);
                        this.Close();
                        break;
                    case DialogResult.No:
                        this.Close();
                        break;
                    default:
                        textBox1.Focus();
                        break;
                }
            }
            else
            {
                this.Close();
            }
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

        private void mi_Edit_Undo_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void mi_Edit_Copy_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void mi_Edit_Cut_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void mi_Edit_Paste_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            if (fontDialog1.ShowDialog()== DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void mi_About_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("老胡记事本--一个用C#编写的记事小工具 Powered by hoopokfung\n\t\t 2019-05-11 江西南昌", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //(new AboutBox().ShowDialog();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
