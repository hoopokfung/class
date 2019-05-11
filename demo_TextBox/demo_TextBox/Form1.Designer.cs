namespace demo_TextBox
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelCols = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mi_File = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.页面设置UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_View = new System.Windows.Forms.ToolStripMenuItem();
            this.Mi_StatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Option = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_AutoLine = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.状态栏SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(770, 426);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.StatusLabelRow,
            this.StatusLabelCols});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(770, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(625, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // StatusLabelRow
            // 
            this.StatusLabelRow.AutoSize = false;
            this.StatusLabelRow.Name = "StatusLabelRow";
            this.StatusLabelRow.Size = new System.Drawing.Size(65, 17);
            this.StatusLabelRow.Text = "1行";
            this.StatusLabelRow.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // StatusLabelCols
            // 
            this.StatusLabelCols.AutoSize = false;
            this.StatusLabelCols.Name = "StatusLabelCols";
            this.StatusLabelCols.Size = new System.Drawing.Size(65, 17);
            this.StatusLabelCols.Text = "1列";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_File,
            this.mi_Edit,
            this.mi_View,
            this.mi_Option,
            this.mi_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mi_File
            // 
            this.mi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.保存SToolStripMenuItem,
            this.另存为AToolStripMenuItem,
            this.toolStripMenuItem1,
            this.页面设置UToolStripMenuItem,
            this.打印PToolStripMenuItem,
            this.toolStripMenuItem2,
            this.退出EToolStripMenuItem});
            this.mi_File.Name = "mi_File";
            this.mi_File.Size = new System.Drawing.Size(58, 21);
            this.mi_File.Text = "文件(&F)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.新建NToolStripMenuItem.Text = "新建(&N)";
            this.新建NToolStripMenuItem.Click += new System.EventHandler(this.Mi_NewFile_Click);
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.Mi_OpenFile_Click);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.Mi_SaveFile_Click);
            // 
            // 另存为AToolStripMenuItem
            // 
            this.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem";
            this.另存为AToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.另存为AToolStripMenuItem.Text = "另存为(&A)";
            this.另存为AToolStripMenuItem.Click += new System.EventHandler(this.Mi_SaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // 页面设置UToolStripMenuItem
            // 
            this.页面设置UToolStripMenuItem.Name = "页面设置UToolStripMenuItem";
            this.页面设置UToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.页面设置UToolStripMenuItem.Text = "页面设置(&U)";
            this.页面设置UToolStripMenuItem.Click += new System.EventHandler(this.Mi_PageSetup_Click);
            // 
            // 打印PToolStripMenuItem
            // 
            this.打印PToolStripMenuItem.Name = "打印PToolStripMenuItem";
            this.打印PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.打印PToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.打印PToolStripMenuItem.Text = "打印(&P)";
            this.打印PToolStripMenuItem.Click += new System.EventHandler(this.Mi_Print_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.退出EToolStripMenuItem.Text = "退出(&E)";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.Mi_Exit_Click);
            // 
            // mi_Edit
            // 
            this.mi_Edit.Name = "mi_Edit";
            this.mi_Edit.Size = new System.Drawing.Size(59, 21);
            this.mi_Edit.Text = "编辑(&E)";
            // 
            // mi_View
            // 
            this.mi_View.Checked = true;
            this.mi_View.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mi_StatusStrip});
            this.mi_View.Name = "mi_View";
            this.mi_View.Size = new System.Drawing.Size(60, 21);
            this.mi_View.Text = "查看(&V)";
            // 
            // Mi_StatusStrip
            // 
            this.Mi_StatusStrip.Checked = true;
            this.Mi_StatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Mi_StatusStrip.Name = "Mi_StatusStrip";
            this.Mi_StatusStrip.Size = new System.Drawing.Size(152, 22);
            this.Mi_StatusStrip.Text = "状态栏(&S)";
            this.Mi_StatusStrip.Click += new System.EventHandler(this.Mi_StatusStrip_Click);
            // 
            // mi_Option
            // 
            this.mi_Option.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_AutoLine,
            this.字体ToolStripMenuItem});
            this.mi_Option.Name = "mi_Option";
            this.mi_Option.Size = new System.Drawing.Size(62, 21);
            this.mi_Option.Text = "格式(O)";
            // 
            // mi_AutoLine
            // 
            this.mi_AutoLine.Checked = true;
            this.mi_AutoLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_AutoLine.Name = "mi_AutoLine";
            this.mi_AutoLine.Size = new System.Drawing.Size(152, 22);
            this.mi_AutoLine.Text = "自动换行(&W)";
            this.mi_AutoLine.Click += new System.EventHandler(this.mi_AutoLine_Click);
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.字体ToolStripMenuItem.Text = "字体(&F)";
            // 
            // mi_Help
            // 
            this.mi_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态栏SToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.mi_Help.Name = "mi_Help";
            this.mi_Help.Size = new System.Drawing.Size(61, 21);
            this.mi_Help.Text = "帮助(&H)";
            // 
            // 状态栏SToolStripMenuItem
            // 
            this.状态栏SToolStripMenuItem.Name = "状态栏SToolStripMenuItem";
            this.状态栏SToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.状态栏SToolStripMenuItem.Text = "查看帮助(&H)";
            this.状态栏SToolStripMenuItem.Click += new System.EventHandler(this.状态栏SToolStripMenuItem_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 451);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "我的记事本";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelRow;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelCols;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_File;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 页面设置UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_Edit;
        private System.Windows.Forms.ToolStripMenuItem mi_Option;
        private System.Windows.Forms.ToolStripMenuItem mi_View;
        private System.Windows.Forms.ToolStripMenuItem mi_Help;
        private System.Windows.Forms.ToolStripMenuItem 打印PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_AutoLine;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态栏SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mi_StatusStrip;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
    }
}

