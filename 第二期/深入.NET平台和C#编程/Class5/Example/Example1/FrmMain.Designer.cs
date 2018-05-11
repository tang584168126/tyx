namespace Example1
{
    partial class FrmMain
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
            this.gbxNew = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblShowPrice = new System.Windows.Forms.Label();
            this.lblShowName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReInsert = new System.Windows.Forms.Button();
            this.cmbCheckItem = new System.Windows.Forms.ComboBox();
            this.gbxCheck = new System.Windows.Forms.GroupBox();
            this.dgvInfoList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbList = new System.Windows.Forms.ComboBox();
            this.lblCheckItem = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.gbxNew.SuspendLayout();
            this.gbxCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxNew
            // 
            this.gbxNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxNew.Controls.Add(this.btnInsert);
            this.gbxNew.Controls.Add(this.txtName);
            this.gbxNew.Controls.Add(this.lblName);
            this.gbxNew.Location = new System.Drawing.Point(12, 12);
            this.gbxNew.Name = "gbxNew";
            this.gbxNew.Size = new System.Drawing.Size(491, 65);
            this.gbxNew.TabIndex = 4;
            this.gbxNew.TabStop = false;
            this.gbxNew.Text = "新建套餐";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(261, 26);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "添加";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "套餐名称";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(314, 95);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(98, 12);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "钱";
            // 
            // lblShowPrice
            // 
            this.lblShowPrice.AutoSize = true;
            this.lblShowPrice.Location = new System.Drawing.Point(254, 95);
            this.lblShowPrice.Name = "lblShowPrice";
            this.lblShowPrice.Size = new System.Drawing.Size(41, 12);
            this.lblShowPrice.TabIndex = 3;
            this.lblShowPrice.Text = "价格：";
            // 
            // lblShowName
            // 
            this.lblShowName.Location = new System.Drawing.Point(91, 95);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(123, 12);
            this.lblShowName.TabIndex = 3;
            this.lblShowName.Text = "  套餐";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(34, 95);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 12);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "套餐名称：";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(399, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReInsert
            // 
            this.btnReInsert.Location = new System.Drawing.Point(316, 55);
            this.btnReInsert.Name = "btnReInsert";
            this.btnReInsert.Size = new System.Drawing.Size(75, 23);
            this.btnReInsert.TabIndex = 2;
            this.btnReInsert.Text = "添加";
            this.btnReInsert.UseVisualStyleBackColor = true;
            this.btnReInsert.Click += new System.EventHandler(this.btnReInsert_Click);
            // 
            // cmbCheckItem
            // 
            this.cmbCheckItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckItem.FormattingEnabled = true;
            this.cmbCheckItem.Location = new System.Drawing.Point(318, 20);
            this.cmbCheckItem.Name = "cmbCheckItem";
            this.cmbCheckItem.Size = new System.Drawing.Size(156, 20);
            this.cmbCheckItem.TabIndex = 1;
            // 
            // gbxCheck
            // 
            this.gbxCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCheck.Controls.Add(this.dgvInfoList);
            this.gbxCheck.Controls.Add(this.lblPrice);
            this.gbxCheck.Controls.Add(this.lblShowPrice);
            this.gbxCheck.Controls.Add(this.lblShowName);
            this.gbxCheck.Controls.Add(this.lblType);
            this.gbxCheck.Controls.Add(this.btnDelete);
            this.gbxCheck.Controls.Add(this.btnReInsert);
            this.gbxCheck.Controls.Add(this.cmbCheckItem);
            this.gbxCheck.Controls.Add(this.cmbList);
            this.gbxCheck.Controls.Add(this.lblCheckItem);
            this.gbxCheck.Controls.Add(this.lblList);
            this.gbxCheck.Location = new System.Drawing.Point(12, 99);
            this.gbxCheck.Name = "gbxCheck";
            this.gbxCheck.Size = new System.Drawing.Size(491, 286);
            this.gbxCheck.TabIndex = 5;
            this.gbxCheck.TabStop = false;
            this.gbxCheck.Text = "检查套餐维护";
            // 
            // dgvInfoList
            // 
            this.dgvInfoList.AllowUserToAddRows = false;
            this.dgvInfoList.AllowUserToDeleteRows = false;
            this.dgvInfoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvInfoList.Location = new System.Drawing.Point(7, 140);
            this.dgvInfoList.Name = "dgvInfoList";
            this.dgvInfoList.ReadOnly = true;
            this.dgvInfoList.RowTemplate.Height = 23;
            this.dgvInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoList.Size = new System.Drawing.Size(467, 140);
            this.dgvInfoList.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ItemName";
            this.Column1.HeaderText = "名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ItemDetail";
            this.Column2.HeaderText = "描述";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ItemPrice";
            this.Column3.HeaderText = "价格";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cmbList
            // 
            this.cmbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbList.FormattingEnabled = true;
            this.cmbList.Location = new System.Drawing.Point(93, 20);
            this.cmbList.Name = "cmbList";
            this.cmbList.Size = new System.Drawing.Size(121, 20);
            this.cmbList.TabIndex = 1;
            this.cmbList.SelectedIndexChanged += new System.EventHandler(this.cmbList_SelectedIndexChanged);
            // 
            // lblCheckItem
            // 
            this.lblCheckItem.AutoSize = true;
            this.lblCheckItem.Location = new System.Drawing.Point(259, 23);
            this.lblCheckItem.Name = "lblCheckItem";
            this.lblCheckItem.Size = new System.Drawing.Size(53, 12);
            this.lblCheckItem.TabIndex = 0;
            this.lblCheckItem.Text = "检查项目";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(34, 23);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(53, 12);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "套餐列表";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 397);
            this.Controls.Add(this.gbxNew);
            this.Controls.Add(this.gbxCheck);
            this.Name = "FrmMain";
            this.Text = "体检套餐管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbxNew.ResumeLayout(false);
            this.gbxNew.PerformLayout();
            this.gbxCheck.ResumeLayout(false);
            this.gbxCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxNew;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblShowPrice;
        private System.Windows.Forms.Label lblShowName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReInsert;
        private System.Windows.Forms.ComboBox cmbCheckItem;
        private System.Windows.Forms.GroupBox gbxCheck;
        private System.Windows.Forms.DataGridView dgvInfoList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cmbList;
        private System.Windows.Forms.Label lblCheckItem;
        private System.Windows.Forms.Label lblList;
    }
}

