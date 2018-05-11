namespace FormMain
{
    partial class SelectForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(65, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "商品名称:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 21);
            this.txtName.TabIndex = 3;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(372, 35);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 14;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pcName,
            this.brand,
            this.pcPrice,
            this.pcDetail,
            this.timeStamp});
            this.dgvList.Location = new System.Drawing.Point(12, 62);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(544, 303);
            this.dgvList.TabIndex = 15;
            // 
            // pcName
            // 
            this.pcName.HeaderText = "商品名";
            this.pcName.Name = "pcName";
            this.pcName.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.HeaderText = "品牌";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            // 
            // pcPrice
            // 
            this.pcPrice.HeaderText = "商品价格";
            this.pcPrice.Name = "pcPrice";
            this.pcPrice.ReadOnly = true;
            // 
            // pcDetail
            // 
            this.pcDetail.HeaderText = "电脑配置";
            this.pcDetail.Name = "pcDetail";
            this.pcDetail.ReadOnly = true;
            // 
            // timeStamp
            // 
            this.timeStamp.HeaderText = "录入时间";
            this.timeStamp.Name = "timeStamp";
            this.timeStamp.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(455, 381);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 426);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询信息";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStamp;
        private System.Windows.Forms.Button btnClose;
    }
}