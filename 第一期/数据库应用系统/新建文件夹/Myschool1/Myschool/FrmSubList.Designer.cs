namespace Myschool
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.cmbGreadID = new System.Windows.Forms.ComboBox();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.lblGreadID = new System.Windows.Forms.Label();
            this.lblSubName = new System.Windows.Forms.Label();
            this.dgvSubList = new System.Windows.Forms.DataGridView();
            this.gbQueryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbQueryInfo
            // 
            this.gbQueryInfo.Controls.Add(this.btnUpdate);
            this.gbQueryInfo.Controls.Add(this.btnQuery);
            this.gbQueryInfo.Controls.Add(this.cmbGreadID);
            this.gbQueryInfo.Controls.Add(this.txtSubName);
            this.gbQueryInfo.Controls.Add(this.lblGreadID);
            this.gbQueryInfo.Controls.Add(this.lblSubName);
            this.gbQueryInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQueryInfo.Location = new System.Drawing.Point(0, 0);
            this.gbQueryInfo.Name = "gbQueryInfo";
            this.gbQueryInfo.Size = new System.Drawing.Size(592, 107);
            this.gbQueryInfo.TabIndex = 0;
            this.gbQueryInfo.TabStop = false;
            this.gbQueryInfo.Text = "查询条件";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(505, 70);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(501, 31);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cmbGreadID
            // 
            this.cmbGreadID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGreadID.FormattingEnabled = true;
            this.cmbGreadID.Location = new System.Drawing.Point(121, 72);
            this.cmbGreadID.Name = "cmbGreadID";
            this.cmbGreadID.Size = new System.Drawing.Size(374, 20);
            this.cmbGreadID.TabIndex = 5;
            // 
            // txtSubName
            // 
            this.txtSubName.Location = new System.Drawing.Point(121, 31);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(374, 21);
            this.txtSubName.TabIndex = 4;
            this.txtSubName.TextChanged += new System.EventHandler(this.txtSubName_TextChanged);
            // 
            // lblGreadID
            // 
            this.lblGreadID.BackColor = System.Drawing.Color.Transparent;
            this.lblGreadID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGreadID.Location = new System.Drawing.Point(24, 67);
            this.lblGreadID.Name = "lblGreadID";
            this.lblGreadID.Size = new System.Drawing.Size(101, 24);
            this.lblGreadID.TabIndex = 3;
            this.lblGreadID.Text = "年 级：";
            this.lblGreadID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubName
            // 
            this.lblSubName.BackColor = System.Drawing.Color.Transparent;
            this.lblSubName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSubName.Location = new System.Drawing.Point(24, 28);
            this.lblSubName.Name = "lblSubName";
            this.lblSubName.Size = new System.Drawing.Size(101, 24);
            this.lblSubName.TabIndex = 2;
            this.lblSubName.Text = "课程名称：";
            this.lblSubName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvSubList
            // 
            this.dgvSubList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSubList.Location = new System.Drawing.Point(0, 113);
            this.dgvSubList.Name = "dgvSubList";
            this.dgvSubList.RowTemplate.Height = 23;
            this.dgvSubList.Size = new System.Drawing.Size(592, 206);
            this.dgvSubList.TabIndex = 1;
            // 
            // FrmSubList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 319);
            this.Controls.Add(this.dgvSubList);
            this.Controls.Add(this.gbQueryInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSubList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程查询";
            this.Load += new System.EventHandler(this.txtSubName_Load);
            this.gbQueryInfo.ResumeLayout(false);
            this.gbQueryInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQueryInfo;
        private System.Windows.Forms.Label lblSubName;
        private System.Windows.Forms.Label lblGreadID;
        private System.Windows.Forms.TextBox txtSubName;
        private System.Windows.Forms.ComboBox cmbGreadID;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvSubList;
    }
}