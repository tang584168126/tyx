namespace MySchool
{
    partial class FrmSubManage
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("S1年级");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("S2年级");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Y2年级");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("全部年级", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubManage));
            this.dgvSubList = new System.Windows.Forms.DataGridView();
            this.tvGradeID = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSubList
            // 
            this.dgvSubList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvSubList.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvSubList.Location = new System.Drawing.Point(127, 0);
            this.dgvSubList.Name = "dgvSubList";
            this.dgvSubList.RowTemplate.Height = 23;
            this.dgvSubList.Size = new System.Drawing.Size(507, 412);
            this.dgvSubList.TabIndex = 0;
            // 
            // tvGradeID
            // 
            this.tvGradeID.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvGradeID.ImageIndex = 0;
            this.tvGradeID.ImageList = this.imgList;
            this.tvGradeID.Location = new System.Drawing.Point(0, 0);
            this.tvGradeID.Name = "tvGradeID";
            treeNode5.Name = "节点1";
            treeNode5.Tag = "1";
            treeNode5.Text = "S1年级";
            treeNode6.Name = "节点2";
            treeNode6.Tag = "2";
            treeNode6.Text = "S2年级";
            treeNode7.Name = "节点3";
            treeNode7.Tag = "3";
            treeNode7.Text = "Y2年级";
            treeNode8.Name = "节点0";
            treeNode8.Text = "全部年级";
            this.tvGradeID.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.tvGradeID.SelectedImageIndex = 1;
            this.tvGradeID.Size = new System.Drawing.Size(121, 412);
            this.tvGradeID.TabIndex = 1;
            this.tvGradeID.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvGradeID_AfterSelect);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "tsbtn1.png");
            this.imgList.Images.SetKeyName(1, "tsbtn2.png");
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SubjectNo";
            this.Column1.HeaderText = "课程编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SubjectName";
            this.Column2.HeaderText = "课程名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GradeID";
            this.Column3.HeaderText = "年级编号";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GradeName";
            this.Column4.HeaderText = "年级名称";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ClassHour";
            this.Column5.HeaderText = "课时";
            this.Column5.Name = "Column5";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // FrmSubManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.tvGradeID);
            this.Controls.Add(this.dgvSubList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSubManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程管理";
            this.Load += new System.EventHandler(this.FrmSubManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubList;
        private System.Windows.Forms.TreeView tvGradeID;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}