namespace Myschool
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.账户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生用户管理sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增学员信息NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学员信息列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按姓名查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按年及查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科目信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.学员信息列表ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.新增学员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBQ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账户管理ToolStripMenuItem,
            this.学生用户管理sToolStripMenuItem,
            this.科目信息管理ToolStripMenuItem,
            this.窗口WToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.MdiWindowListItem = this.科目信息管理ToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 账户管理ToolStripMenuItem
            // 
            this.账户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            resources.ApplyResources(this.账户管理ToolStripMenuItem, "账户管理ToolStripMenuItem");
            this.账户管理ToolStripMenuItem.Name = "账户管理ToolStripMenuItem";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            resources.ApplyResources(this.修改密码ToolStripMenuItem, "修改密码ToolStripMenuItem");
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            resources.ApplyResources(this.退出ToolStripMenuItem, "退出ToolStripMenuItem");
            // 
            // 学生用户管理sToolStripMenuItem
            // 
            this.学生用户管理sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增学员信息NToolStripMenuItem,
            this.学员信息列表ToolStripMenuItem,
            this.按姓名查询ToolStripMenuItem,
            this.按年及查询ToolStripMenuItem});
            resources.ApplyResources(this.学生用户管理sToolStripMenuItem, "学生用户管理sToolStripMenuItem");
            this.学生用户管理sToolStripMenuItem.Name = "学生用户管理sToolStripMenuItem";
            // 
            // 新增学员信息NToolStripMenuItem
            // 
            this.新增学员信息NToolStripMenuItem.Name = "新增学员信息NToolStripMenuItem";
            resources.ApplyResources(this.新增学员信息NToolStripMenuItem, "新增学员信息NToolStripMenuItem");
            this.新增学员信息NToolStripMenuItem.Click += new System.EventHandler(this.新增学员信息NToolStripMenuItem_Click);
            // 
            // 学员信息列表ToolStripMenuItem
            // 
            this.学员信息列表ToolStripMenuItem.Name = "学员信息列表ToolStripMenuItem";
            resources.ApplyResources(this.学员信息列表ToolStripMenuItem, "学员信息列表ToolStripMenuItem");
            this.学员信息列表ToolStripMenuItem.Click += new System.EventHandler(this.学员信息列表ToolStripMenuItem_Click);
            // 
            // 按姓名查询ToolStripMenuItem
            // 
            this.按姓名查询ToolStripMenuItem.Name = "按姓名查询ToolStripMenuItem";
            resources.ApplyResources(this.按姓名查询ToolStripMenuItem, "按姓名查询ToolStripMenuItem");
            this.按姓名查询ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // 按年及查询ToolStripMenuItem
            // 
            this.按年及查询ToolStripMenuItem.Name = "按年及查询ToolStripMenuItem";
            resources.ApplyResources(this.按年及查询ToolStripMenuItem, "按年及查询ToolStripMenuItem");
            this.按年及查询ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // 科目信息管理ToolStripMenuItem
            // 
            this.科目信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.课程查询ToolStripMenuItem,
            this.课程管理ToolStripMenuItem});
            resources.ApplyResources(this.科目信息管理ToolStripMenuItem, "科目信息管理ToolStripMenuItem");
            this.科目信息管理ToolStripMenuItem.Name = "科目信息管理ToolStripMenuItem";
            // 
            // 课程查询ToolStripMenuItem
            // 
            this.课程查询ToolStripMenuItem.Name = "课程查询ToolStripMenuItem";
            resources.ApplyResources(this.课程查询ToolStripMenuItem, "课程查询ToolStripMenuItem");
            this.课程查询ToolStripMenuItem.Click += new System.EventHandler(this.课程查询ToolStripMenuItem_Click);
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            resources.ApplyResources(this.课程管理ToolStripMenuItem, "课程管理ToolStripMenuItem");
            // 
            // 窗口WToolStripMenuItem
            // 
            resources.ApplyResources(this.窗口WToolStripMenuItem, "窗口WToolStripMenuItem");
            this.窗口WToolStripMenuItem.Name = "窗口WToolStripMenuItem";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于系统ToolStripMenuItem});
            resources.ApplyResources(this.帮助HToolStripMenuItem, "帮助HToolStripMenuItem");
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            // 
            // 关于系统ToolStripMenuItem
            // 
            this.关于系统ToolStripMenuItem.Name = "关于系统ToolStripMenuItem";
            resources.ApplyResources(this.关于系统ToolStripMenuItem, "关于系统ToolStripMenuItem");
            this.关于系统ToolStripMenuItem.Click += new System.EventHandler(this.关于系统ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripButton3,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.新增学员信息NToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.学员信息列表ToolStripMenuItem_Click);
            // 
            // toolStripButton4
            // 
            resources.ApplyResources(this.toolStripButton4, "toolStripButton4");
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton3
            // 
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton5
            // 
            resources.ApplyResources(this.toolStripButton5, "toolStripButton5");
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.课程查询ToolStripMenuItem_Click);
            // 
            // toolStripButton6
            // 
            resources.ApplyResources(this.toolStripButton6, "toolStripButton6");
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.toolStripSeparator2,
            this.学员信息列表ToolStripMenuItem1,
            this.修改密码ToolStripMenuItem1,
            this.toolStripSeparator6,
            this.退出系统ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Click += new System.EventHandler(this.新增学员信息NToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // 学员信息列表ToolStripMenuItem1
            // 
            this.学员信息列表ToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.学员信息列表ToolStripMenuItem1.ForeColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.学员信息列表ToolStripMenuItem1, "学员信息列表ToolStripMenuItem1");
            this.学员信息列表ToolStripMenuItem1.Name = "学员信息列表ToolStripMenuItem1";
            this.学员信息列表ToolStripMenuItem1.Click += new System.EventHandler(this.学员信息列表ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem1
            // 
            this.修改密码ToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.修改密码ToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.修改密码ToolStripMenuItem1, "修改密码ToolStripMenuItem1");
            this.修改密码ToolStripMenuItem1.Name = "修改密码ToolStripMenuItem1";
            this.修改密码ToolStripMenuItem1.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.退出系统ToolStripMenuItem.ForeColor = System.Drawing.Color.Purple;
            resources.ApplyResources(this.退出系统ToolStripMenuItem, "退出系统ToolStripMenuItem");
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // 新增学员信息ToolStripMenuItem
            // 
            this.新增学员信息ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.新增学员信息ToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.新增学员信息ToolStripMenuItem, "新增学员信息ToolStripMenuItem");
            this.新增学员信息ToolStripMenuItem.Name = "新增学员信息ToolStripMenuItem";
            this.新增学员信息ToolStripMenuItem.Click += new System.EventHandler(this.新增学员信息NToolStripMenuItem_Click);
            // 
            // lblBQ
            // 
            this.lblBQ.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblBQ, "lblBQ");
            this.lblBQ.ForeColor = System.Drawing.Color.Red;
            this.lblBQ.Name = "lblBQ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Name = "label2";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBQ);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 账户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 学生用户管理sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增学员信息NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学员信息列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按姓名查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按年及查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学员信息列表ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 新增学员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 科目信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于系统ToolStripMenuItem;
        private System.Windows.Forms.Label lblBQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 课程查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程管理ToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}