namespace Myschool
{
    partial class FrmStuUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStuUpdate));
            this.btnConcel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.lblts = new System.Windows.Forms.Label();
            this.dtpBornDate = new System.Windows.Forms.DateTimePicker();
            this.plSex = new System.Windows.Forms.Panel();
            this.cmbGradID = new System.Windows.Forms.ComboBox();
            this.lblStuNo = new System.Windows.Forms.Label();
            this.gbBaseInfo = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddess = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBornDate = new System.Windows.Forms.Label();
            this.lblAddess = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblStuGradID = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.gbRegionInfo = new System.Windows.Forms.GroupBox();
            this.plSex.SuspendLayout();
            this.gbBaseInfo.SuspendLayout();
            this.gbRegionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConcel
            // 
            this.btnConcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConcel.BackgroundImage")));
            this.btnConcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConcel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConcel.Location = new System.Drawing.Point(354, 537);
            this.btnConcel.Name = "btnConcel";
            this.btnConcel.Size = new System.Drawing.Size(75, 23);
            this.btnConcel.TabIndex = 23;
            this.btnConcel.Text = "还原";
            this.btnConcel.UseVisualStyleBackColor = true;
            this.btnConcel.Click += new System.EventHandler(this.btnConcel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(256, 537);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(98, 3);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(43, 20);
            this.rbtFemale.TabIndex = 1;
            this.rbtFemale.Text = "女";
            this.rbtFemale.UseVisualStyleBackColor = true;
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Checked = true;
            this.rbtMale.Location = new System.Drawing.Point(3, 3);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(43, 20);
            this.rbtMale.TabIndex = 0;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "男";
            this.rbtMale.UseVisualStyleBackColor = true;
            // 
            // lblts
            // 
            this.lblts.AutoSize = true;
            this.lblts.BackColor = System.Drawing.Color.Transparent;
            this.lblts.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblts.Location = new System.Drawing.Point(0, 76);
            this.lblts.Name = "lblts";
            this.lblts.Size = new System.Drawing.Size(65, 10);
            this.lblts.TabIndex = 25;
            this.lblts.Text = "在此选择性别";
            // 
            // dtpBornDate
            // 
            this.dtpBornDate.Location = new System.Drawing.Point(147, 236);
            this.dtpBornDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpBornDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBornDate.Name = "dtpBornDate";
            this.dtpBornDate.Size = new System.Drawing.Size(239, 26);
            this.dtpBornDate.TabIndex = 24;
            this.dtpBornDate.Value = new System.DateTime(1994, 8, 25, 0, 0, 0, 0);
            // 
            // plSex
            // 
            this.plSex.Controls.Add(this.rbtFemale);
            this.plSex.Controls.Add(this.rbtMale);
            this.plSex.Location = new System.Drawing.Point(147, 70);
            this.plSex.Name = "plSex";
            this.plSex.Size = new System.Drawing.Size(239, 26);
            this.plSex.TabIndex = 23;
            // 
            // cmbGradID
            // 
            this.cmbGradID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradID.FormattingEnabled = true;
            this.cmbGradID.Location = new System.Drawing.Point(147, 112);
            this.cmbGradID.Name = "cmbGradID";
            this.cmbGradID.Size = new System.Drawing.Size(239, 24);
            this.cmbGradID.TabIndex = 22;
            // 
            // lblStuNo
            // 
            this.lblStuNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuNo.ForeColor = System.Drawing.Color.Red;
            this.lblStuNo.Location = new System.Drawing.Point(48, 22);
            this.lblStuNo.Name = "lblStuNo";
            this.lblStuNo.Size = new System.Drawing.Size(93, 35);
            this.lblStuNo.TabIndex = 1;
            this.lblStuNo.Text = "学 号：";
            this.lblStuNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbBaseInfo
            // 
            this.gbBaseInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbBaseInfo.Controls.Add(this.lblts);
            this.gbBaseInfo.Controls.Add(this.dtpBornDate);
            this.gbBaseInfo.Controls.Add(this.plSex);
            this.gbBaseInfo.Controls.Add(this.cmbGradID);
            this.gbBaseInfo.Controls.Add(this.txtEmail);
            this.gbBaseInfo.Controls.Add(this.txtAddess);
            this.gbBaseInfo.Controls.Add(this.txtPhone);
            this.gbBaseInfo.Controls.Add(this.txtName);
            this.gbBaseInfo.Controls.Add(this.lblEmail);
            this.gbBaseInfo.Controls.Add(this.lblBornDate);
            this.gbBaseInfo.Controls.Add(this.lblAddess);
            this.gbBaseInfo.Controls.Add(this.lblPhone);
            this.gbBaseInfo.Controls.Add(this.lblStuGradID);
            this.gbBaseInfo.Controls.Add(this.lblSex);
            this.gbBaseInfo.Controls.Add(this.lblStuName);
            this.gbBaseInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbBaseInfo.Location = new System.Drawing.Point(11, 213);
            this.gbBaseInfo.Name = "gbBaseInfo";
            this.gbBaseInfo.Size = new System.Drawing.Size(418, 318);
            this.gbBaseInfo.TabIndex = 21;
            this.gbBaseInfo.TabStop = false;
            this.gbBaseInfo.Text = "用户基本信息";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 278);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 26);
            this.txtEmail.TabIndex = 21;
            // 
            // txtAddess
            // 
            this.txtAddess.Location = new System.Drawing.Point(147, 194);
            this.txtAddess.MaxLength = 50;
            this.txtAddess.Name = "txtAddess";
            this.txtAddess.Size = new System.Drawing.Size(239, 26);
            this.txtAddess.TabIndex = 20;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(147, 152);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(239, 26);
            this.txtPhone.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 26);
            this.txtName.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmail.Location = new System.Drawing.Point(48, 272);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(93, 35);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Emali：";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBornDate
            // 
            this.lblBornDate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBornDate.Location = new System.Drawing.Point(48, 234);
            this.lblBornDate.Name = "lblBornDate";
            this.lblBornDate.Size = new System.Drawing.Size(93, 35);
            this.lblBornDate.TabIndex = 17;
            this.lblBornDate.Text = "出生日期：";
            this.lblBornDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddess
            // 
            this.lblAddess.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddess.Location = new System.Drawing.Point(48, 188);
            this.lblAddess.Name = "lblAddess";
            this.lblAddess.Size = new System.Drawing.Size(93, 35);
            this.lblAddess.TabIndex = 16;
            this.lblAddess.Text = "地 址：";
            this.lblAddess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhone.Location = new System.Drawing.Point(48, 146);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(93, 35);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "电 话：";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStuGradID
            // 
            this.lblStuGradID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuGradID.Location = new System.Drawing.Point(48, 106);
            this.lblStuGradID.Name = "lblStuGradID";
            this.lblStuGradID.Size = new System.Drawing.Size(93, 35);
            this.lblStuGradID.TabIndex = 14;
            this.lblStuGradID.Text = "年 级：";
            this.lblStuGradID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSex
            // 
            this.lblSex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSex.Location = new System.Drawing.Point(48, 67);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(93, 35);
            this.lblSex.TabIndex = 13;
            this.lblSex.Text = "性 别：";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStuName
            // 
            this.lblStuName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuName.Location = new System.Drawing.Point(48, 22);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(93, 35);
            this.lblStuName.TabIndex = 12;
            this.lblStuName.Text = "姓 名：";
            this.lblStuName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStuNo
            // 
            this.txtStuNo.BackColor = System.Drawing.Color.Lime;
            this.txtStuNo.Location = new System.Drawing.Point(147, 28);
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.ReadOnly = true;
            this.txtStuNo.Size = new System.Drawing.Size(239, 26);
            this.txtStuNo.TabIndex = 9;
            // 
            // gbRegionInfo
            // 
            this.gbRegionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRegionInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbRegionInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbRegionInfo.Controls.Add(this.txtStuNo);
            this.gbRegionInfo.Controls.Add(this.lblStuNo);
            this.gbRegionInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbRegionInfo.Location = new System.Drawing.Point(11, 23);
            this.gbRegionInfo.Name = "gbRegionInfo";
            this.gbRegionInfo.Size = new System.Drawing.Size(418, 158);
            this.gbRegionInfo.TabIndex = 20;
            this.gbRegionInfo.TabStop = false;
            this.gbRegionInfo.Text = "用户注册信息";
            // 
            // FrmStuUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 583);
            this.Controls.Add(this.btnConcel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbBaseInfo);
            this.Controls.Add(this.gbRegionInfo);
            this.Name = "FrmStuUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改学员信息";
            this.Load += new System.EventHandler(this.FrmStuUpdate_Load);
            this.plSex.ResumeLayout(false);
            this.plSex.PerformLayout();
            this.gbBaseInfo.ResumeLayout(false);
            this.gbBaseInfo.PerformLayout();
            this.gbRegionInfo.ResumeLayout(false);
            this.gbRegionInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConcel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.Label lblts;
        private System.Windows.Forms.DateTimePicker dtpBornDate;
        private System.Windows.Forms.Panel plSex;
        private System.Windows.Forms.ComboBox cmbGradID;
        private System.Windows.Forms.Label lblStuNo;
        private System.Windows.Forms.GroupBox gbBaseInfo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddess;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBornDate;
        private System.Windows.Forms.Label lblAddess;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblStuGradID;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.GroupBox gbRegionInfo;
    }
}