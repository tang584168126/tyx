namespace Myschool
{
    partial class FrmAXMCX
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.gbBaseInfo = new System.Windows.Forms.GroupBox();
            this.lvSelect1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblyc = new System.Windows.Forms.Label();
            this.gbInfo.SuspendLayout();
            this.gbBaseInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.lblName);
            this.gbInfo.Controls.Add(this.btnSelect);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(681, 100);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "请输入您要查询的姓名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 37);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(444, 21);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "请输入您的姓名：";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(591, 71);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gbBaseInfo
            // 
            this.gbBaseInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBaseInfo.Controls.Add(this.lvSelect1);
            this.gbBaseInfo.Location = new System.Drawing.Point(12, 154);
            this.gbBaseInfo.Name = "gbBaseInfo";
            this.gbBaseInfo.Size = new System.Drawing.Size(681, 286);
            this.gbBaseInfo.TabIndex = 1;
            this.gbBaseInfo.TabStop = false;
            this.gbBaseInfo.Text = "查询结果";
            // 
            // lvSelect1
            // 
            this.lvSelect1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvSelect1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSelect1.Location = new System.Drawing.Point(3, 17);
            this.lvSelect1.Name = "lvSelect1";
            this.lvSelect1.Size = new System.Drawing.Size(675, 266);
            this.lvSelect1.TabIndex = 0;
            this.lvSelect1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "学号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "年级";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "电话";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "出生日期";
            this.columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "地址";
            this.columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Email";
            // 
            // lblyc
            // 
            this.lblyc.BackColor = System.Drawing.Color.Transparent;
            this.lblyc.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblyc.ForeColor = System.Drawing.Color.Red;
            this.lblyc.Location = new System.Drawing.Point(131, 115);
            this.lblyc.Name = "lblyc";
            this.lblyc.Size = new System.Drawing.Size(444, 40);
            this.lblyc.TabIndex = 1;
            // 
            // FrmAXMCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 452);
            this.Controls.Add(this.lblyc);
            this.Controls.Add(this.gbBaseInfo);
            this.Controls.Add(this.gbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAXMCX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAXMCX";
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbBaseInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbBaseInfo;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListView lvSelect1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lblyc;
    }
}