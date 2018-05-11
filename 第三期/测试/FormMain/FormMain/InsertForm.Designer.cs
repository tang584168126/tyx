namespace FormMain
{
    partial class InsertForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.rbtYet = new System.Windows.Forms.RadioButton();
            this.rbtNot = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalsole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "增加商品信息";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(50, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "商品名:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 21);
            this.txtName.TabIndex = 2;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRemark.Location = new System.Drawing.Point(50, 303);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(48, 16);
            this.lblRemark.TabIndex = 3;
            this.lblRemark.Text = "备注:";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDetail.Location = new System.Drawing.Point(50, 220);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(48, 16);
            this.lblDetail.TabIndex = 4;
            this.lblDetail.Text = "配置:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrice.Location = new System.Drawing.Point(50, 166);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 16);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "价格:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBrand.Location = new System.Drawing.Point(50, 112);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(48, 16);
            this.lblBrand.TabIndex = 6;
            this.lblBrand.Text = "品牌:";
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(137, 107);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(133, 20);
            this.cmbBrand.TabIndex = 7;
            // 
            // rbtYet
            // 
            this.rbtYet.AutoSize = true;
            this.rbtYet.Checked = true;
            this.rbtYet.Location = new System.Drawing.Point(137, 134);
            this.rbtYet.Name = "rbtYet";
            this.rbtYet.Size = new System.Drawing.Size(59, 16);
            this.rbtYet.TabIndex = 8;
            this.rbtYet.TabStop = true;
            this.rbtYet.Text = "已到货";
            this.rbtYet.UseVisualStyleBackColor = true;
            // 
            // rbtNot
            // 
            this.rbtNot.AutoSize = true;
            this.rbtNot.Location = new System.Drawing.Point(203, 134);
            this.rbtNot.Name = "rbtNot";
            this.rbtNot.Size = new System.Drawing.Size(59, 16);
            this.rbtNot.TabIndex = 9;
            this.rbtNot.Text = "未到货";
            this.rbtNot.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(137, 167);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(133, 21);
            this.txtPrice.TabIndex = 10;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(137, 214);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(225, 54);
            this.txtDetail.TabIndex = 11;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(137, 284);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(225, 54);
            this.txtRemark.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(67, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(241, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalsole
            // 
            this.btnCalsole.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalsole.Location = new System.Drawing.Point(150, 360);
            this.btnCalsole.Name = "btnCalsole";
            this.btnCalsole.Size = new System.Drawing.Size(75, 23);
            this.btnCalsole.TabIndex = 15;
            this.btnCalsole.Text = "取消";
            this.btnCalsole.UseVisualStyleBackColor = true;
            this.btnCalsole.Click += new System.EventHandler(this.btnCalsole_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 431);
            this.Controls.Add(this.btnCalsole);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.rbtNot);
            this.Controls.Add(this.rbtYet);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Name = "InsertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加信息";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.RadioButton rbtYet;
        private System.Windows.Forms.RadioButton rbtNot;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalsole;
    }
}