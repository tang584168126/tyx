namespace Test
{
    partial class frmMain
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
            this.gbList = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbTest = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.lblPriceN = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItemN = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnItemsAdd = new System.Windows.Forms.Button();
            this.cmbItemList = new System.Windows.Forms.ComboBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.cmbList = new System.Windows.Forms.ComboBox();
            this.lblList = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbList.SuspendLayout();
            this.gbTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.btnInsert);
            this.gbList.Controls.Add(this.txtName);
            this.gbList.Controls.Add(this.lblName);
            this.gbList.Location = new System.Drawing.Point(13, 12);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(553, 50);
            this.gbList.TabIndex = 0;
            this.gbList.TabStop = false;
            this.gbList.Text = "新建套餐";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInsert.Location = new System.Drawing.Point(402, 20);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "添加";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(46, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "套餐名称";
            // 
            // gbTest
            // 
            this.gbTest.Controls.Add(this.dgvList);
            this.gbTest.Controls.Add(this.lblPriceN);
            this.gbTest.Controls.Add(this.lblPrice);
            this.gbTest.Controls.Add(this.lblItemN);
            this.gbTest.Controls.Add(this.lblItemName);
            this.gbTest.Controls.Add(this.btnClear);
            this.gbTest.Controls.Add(this.btnItemsAdd);
            this.gbTest.Controls.Add(this.cmbItemList);
            this.gbTest.Controls.Add(this.lblItems);
            this.gbTest.Controls.Add(this.cmbList);
            this.gbTest.Controls.Add(this.lblList);
            this.gbTest.Location = new System.Drawing.Point(13, 68);
            this.gbTest.Name = "gbTest";
            this.gbTest.Size = new System.Drawing.Size(553, 296);
            this.gbTest.TabIndex = 1;
            this.gbTest.TabStop = false;
            this.gbTest.Text = "检查套餐维护";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvList.Location = new System.Drawing.Point(26, 132);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(497, 141);
            this.dgvList.TabIndex = 10;
            // 
            // lblPriceN
            // 
            this.lblPriceN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPriceN.Location = new System.Drawing.Point(305, 101);
            this.lblPriceN.Name = "lblPriceN";
            this.lblPriceN.Size = new System.Drawing.Size(95, 16);
            this.lblPriceN.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrice.Location = new System.Drawing.Point(248, 101);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 16);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "价格:";
            // 
            // lblItemN
            // 
            this.lblItemN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblItemN.Location = new System.Drawing.Point(120, 101);
            this.lblItemN.Name = "lblItemN";
            this.lblItemN.Size = new System.Drawing.Size(95, 16);
            this.lblItemN.TabIndex = 7;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblItemName.Location = new System.Drawing.Point(46, 101);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(68, 16);
            this.lblItemName.TabIndex = 6;
            this.lblItemName.Text = "套餐名:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(391, 67);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "删除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnItemsAdd
            // 
            this.btnItemsAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnItemsAdd.Location = new System.Drawing.Point(293, 67);
            this.btnItemsAdd.Name = "btnItemsAdd";
            this.btnItemsAdd.Size = new System.Drawing.Size(75, 23);
            this.btnItemsAdd.TabIndex = 3;
            this.btnItemsAdd.Text = "添加";
            this.btnItemsAdd.UseVisualStyleBackColor = true;
            this.btnItemsAdd.Click += new System.EventHandler(this.btnItemsAdd_Click);
            // 
            // cmbItemList
            // 
            this.cmbItemList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemList.FormattingEnabled = true;
            this.cmbItemList.Items.AddRange(new object[] {
            "请选择",
            "身高",
            "体重",
            "视力",
            "听力",
            "肝功能",
            "B超",
            "心电图"});
            this.cmbItemList.Location = new System.Drawing.Point(372, 31);
            this.cmbItemList.Name = "cmbItemList";
            this.cmbItemList.Size = new System.Drawing.Size(151, 20);
            this.cmbItemList.TabIndex = 4;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblItems.Location = new System.Drawing.Point(290, 32);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(76, 16);
            this.lblItems.TabIndex = 3;
            this.lblItems.Text = "检查项目";
            // 
            // cmbList
            // 
            this.cmbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbList.FormattingEnabled = true;
            this.cmbList.Items.AddRange(new object[] {
            "请选择",
            "入学体检"});
            this.cmbList.Location = new System.Drawing.Point(144, 31);
            this.cmbList.Name = "cmbList";
            this.cmbList.Size = new System.Drawing.Size(124, 20);
            this.cmbList.TabIndex = 2;
            this.cmbList.SelectedIndexChanged += new System.EventHandler(this.cmbList_SelectedIndexChanged);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblList.Location = new System.Drawing.Point(46, 31);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(76, 16);
            this.lblList.TabIndex = 1;
            this.lblList.Text = "套餐列表";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "itemName";
            this.Column1.HeaderText = "名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "itemDesc";
            this.Column2.HeaderText = "描述";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "itemPrice";
            this.Column3.HeaderText = "价格";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 153;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 376);
            this.Controls.Add(this.gbTest);
            this.Controls.Add(this.gbList);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "体检套餐管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            this.gbTest.ResumeLayout(false);
            this.gbTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.GroupBox gbTest;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbItemList;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.ComboBox cmbList;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnItemsAdd;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblPriceN;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItemN;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

