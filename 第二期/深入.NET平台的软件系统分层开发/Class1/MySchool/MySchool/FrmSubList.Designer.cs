namespace MySchool
{
    partial class FrmSubList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubList));
            this.gbQueryInfo = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnQuary = new System.Windows.Forms.Button();
            this.lalSubName = new System.Windows.Forms.Label();
            this.dgvSubList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSubName = new System.Windows.Forms.ComboBox();
            this.gbQueryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbQueryInfo
            // 
            this.gbQueryInfo.Controls.Add(this.btnUpdate);
            this.gbQueryInfo.Controls.Add(this.btnQuary);
            this.gbQueryInfo.Controls.Add(this.cmbSubName);
            this.gbQueryInfo.Controls.Add(this.lalSubName);
            this.gbQueryInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQueryInfo.Location = new System.Drawing.Point(0, 0);
            this.gbQueryInfo.Name = "gbQueryInfo";
            this.gbQueryInfo.Size = new System.Drawing.Size(584, 112);
            this.gbQueryInfo.TabIndex = 1;
            this.gbQueryInfo.TabStop = false;
            this.gbQueryInfo.Text = "查询条件";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(470, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "更 新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnQuary
            // 
            this.btnQuary.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuary.Location = new System.Drawing.Point(470, 24);
            this.btnQuary.Name = "btnQuary";
            this.btnQuary.Size = new System.Drawing.Size(75, 23);
            this.btnQuary.TabIndex = 7;
            this.btnQuary.Text = "查 询";
            this.btnQuary.UseVisualStyleBackColor = true;
            this.btnQuary.Click += new System.EventHandler(this.btnQuary_Click);
            // 
            // lalSubName
            // 
            this.lalSubName.AutoSize = true;
            this.lalSubName.BackColor = System.Drawing.Color.Transparent;
            this.lalSubName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalSubName.Location = new System.Drawing.Point(31, 26);
            this.lalSubName.Name = "lalSubName";
            this.lalSubName.Size = new System.Drawing.Size(93, 16);
            this.lalSubName.TabIndex = 1;
            this.lalSubName.Text = "年级名称：";
            this.lalSubName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvSubList
            // 
            this.dgvSubList.AllowUserToAddRows = false;
            this.dgvSubList.AllowUserToDeleteRows = false;
            this.dgvSubList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dgvSubList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSubList.Location = new System.Drawing.Point(0, 110);
            this.dgvSubList.Name = "dgvSubList";
            this.dgvSubList.ReadOnly = true;
            this.dgvSubList.RowTemplate.Height = 23;
            this.dgvSubList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubList.Size = new System.Drawing.Size(584, 175);
            this.dgvSubList.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SubjectNo";
            this.Column1.HeaderText = "课程编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SubjectName";
            this.Column2.HeaderText = "课程名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ClassHour";
            this.Column4.HeaderText = "课时";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GradeID";
            this.Column3.HeaderText = "年级编号";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cmbSubName
            // 
            this.cmbSubName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubName.FormattingEnabled = true;
            this.cmbSubName.Items.AddRange(new object[] {
            "管理员",
            "普通用户"});
            this.cmbSubName.Location = new System.Drawing.Point(144, 24);
            this.cmbSubName.Name = "cmbSubName";
            this.cmbSubName.Size = new System.Drawing.Size(306, 20);
            this.cmbSubName.TabIndex = 6;
            // 
            // FrmSubList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 285);
            this.Controls.Add(this.dgvSubList);
            this.Controls.Add(this.gbQueryInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSubList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程查询";
            this.Load += new System.EventHandler(this.FrmSubList_Load);
            this.gbQueryInfo.ResumeLayout(false);
            this.gbQueryInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQueryInfo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnQuary;
        private System.Windows.Forms.Label lalSubName;
        private System.Windows.Forms.DataGridView dgvSubList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cmbSubName;
    }
}