namespace MySchool
{
    partial class FrmAddStu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddStu));
            this.gbRegion = new System.Windows.Forms.GroupBox();
            this.txtPwdSure = new System.Windows.Forms.TextBox();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.txtStuNO = new System.Windows.Forms.TextBox();
            this.lblPwdSure = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblStuNO = new System.Windows.Forms.Label();
            this.gbBasic = new System.Windows.Forms.GroupBox();
            this.dtpBornDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.cmbGradeID = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBornDate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGradeID = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbRegion.SuspendLayout();
            this.gbBasic.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegion
            // 
            this.gbRegion.Controls.Add(this.txtPwdSure);
            this.gbRegion.Controls.Add(this.txtLoginPwd);
            this.gbRegion.Controls.Add(this.txtStuNO);
            this.gbRegion.Controls.Add(this.lblPwdSure);
            this.gbRegion.Controls.Add(this.lblPwd);
            this.gbRegion.Controls.Add(this.lblStuNO);
            this.gbRegion.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbRegion.Location = new System.Drawing.Point(0, 0);
            this.gbRegion.Name = "gbRegion";
            this.gbRegion.Size = new System.Drawing.Size(394, 144);
            this.gbRegion.TabIndex = 0;
            this.gbRegion.TabStop = false;
            this.gbRegion.Text = "用户注册信息";
            // 
            // txtPwdSure
            // 
            this.txtPwdSure.Location = new System.Drawing.Point(127, 104);
            this.txtPwdSure.MaxLength = 20;
            this.txtPwdSure.Name = "txtPwdSure";
            this.txtPwdSure.PasswordChar = '*';
            this.txtPwdSure.Size = new System.Drawing.Size(195, 21);
            this.txtPwdSure.TabIndex = 6;
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Location = new System.Drawing.Point(127, 67);
            this.txtLoginPwd.MaxLength = 20;
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(195, 21);
            this.txtLoginPwd.TabIndex = 5;
            // 
            // txtStuNO
            // 
            this.txtStuNO.Location = new System.Drawing.Point(127, 31);
            this.txtStuNO.MaxLength = 20;
            this.txtStuNO.Name = "txtStuNO";
            this.txtStuNO.Size = new System.Drawing.Size(195, 21);
            this.txtStuNO.TabIndex = 4;
            // 
            // lblPwdSure
            // 
            this.lblPwdSure.BackColor = System.Drawing.Color.Transparent;
            this.lblPwdSure.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwdSure.Location = new System.Drawing.Point(12, 104);
            this.lblPwdSure.Name = "lblPwdSure";
            this.lblPwdSure.Size = new System.Drawing.Size(90, 23);
            this.lblPwdSure.TabIndex = 3;
            this.lblPwdSure.Text = "确认密码";
            this.lblPwdSure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPwd
            // 
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(12, 65);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(90, 23);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "密  码";
            this.lblPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStuNO
            // 
            this.lblStuNO.BackColor = System.Drawing.Color.Transparent;
            this.lblStuNO.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuNO.Location = new System.Drawing.Point(12, 26);
            this.lblStuNO.Name = "lblStuNO";
            this.lblStuNO.Size = new System.Drawing.Size(90, 23);
            this.lblStuNO.TabIndex = 1;
            this.lblStuNO.Text = "学  号";
            this.lblStuNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbBasic
            // 
            this.gbBasic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBasic.Controls.Add(this.dtpBornDate);
            this.gbBasic.Controls.Add(this.panel1);
            this.gbBasic.Controls.Add(this.cmbGradeID);
            this.gbBasic.Controls.Add(this.txtEmail);
            this.gbBasic.Controls.Add(this.txtAddress);
            this.gbBasic.Controls.Add(this.txtPhone);
            this.gbBasic.Controls.Add(this.txtStuName);
            this.gbBasic.Controls.Add(this.lblEmail);
            this.gbBasic.Controls.Add(this.lblBornDate);
            this.gbBasic.Controls.Add(this.lblAddress);
            this.gbBasic.Controls.Add(this.lblPhone);
            this.gbBasic.Controls.Add(this.lblGradeID);
            this.gbBasic.Controls.Add(this.lblSex);
            this.gbBasic.Controls.Add(this.lblStuName);
            this.gbBasic.Location = new System.Drawing.Point(0, 188);
            this.gbBasic.Name = "gbBasic";
            this.gbBasic.Size = new System.Drawing.Size(394, 278);
            this.gbBasic.TabIndex = 1;
            this.gbBasic.TabStop = false;
            this.gbBasic.Text = "用户基本信息";
            // 
            // dtpBornDate
            // 
            this.dtpBornDate.Location = new System.Drawing.Point(127, 214);
            this.dtpBornDate.Name = "dtpBornDate";
            this.dtpBornDate.Size = new System.Drawing.Size(195, 21);
            this.dtpBornDate.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtFemale);
            this.panel1.Controls.Add(this.rbtMale);
            this.panel1.Location = new System.Drawing.Point(127, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 22);
            this.panel1.TabIndex = 14;
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(79, 3);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(35, 16);
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
            this.rbtMale.Size = new System.Drawing.Size(35, 16);
            this.rbtMale.TabIndex = 0;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "男";
            this.rbtMale.UseVisualStyleBackColor = true;
            // 
            // cmbGradeID
            // 
            this.cmbGradeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradeID.FormattingEnabled = true;
            this.cmbGradeID.Location = new System.Drawing.Point(127, 105);
            this.cmbGradeID.Name = "cmbGradeID";
            this.cmbGradeID.Size = new System.Drawing.Size(195, 20);
            this.cmbGradeID.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(127, 251);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 21);
            this.txtEmail.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(127, 182);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(195, 21);
            this.txtAddress.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(127, 140);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(195, 21);
            this.txtPhone.TabIndex = 10;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(127, 30);
            this.txtStuName.MaxLength = 20;
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(195, 21);
            this.txtStuName.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEmail.Location = new System.Drawing.Point(12, 251);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(90, 23);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBornDate
            // 
            this.lblBornDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBornDate.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBornDate.Location = new System.Drawing.Point(12, 214);
            this.lblBornDate.Name = "lblBornDate";
            this.lblBornDate.Size = new System.Drawing.Size(90, 23);
            this.lblBornDate.TabIndex = 7;
            this.lblBornDate.Text = "出生日期";
            this.lblBornDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.Location = new System.Drawing.Point(12, 177);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(90, 23);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "地  址";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhone.Location = new System.Drawing.Point(12, 140);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(90, 23);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "电  话";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGradeID
            // 
            this.lblGradeID.BackColor = System.Drawing.Color.Transparent;
            this.lblGradeID.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGradeID.Location = new System.Drawing.Point(12, 103);
            this.lblGradeID.Name = "lblGradeID";
            this.lblGradeID.Size = new System.Drawing.Size(90, 23);
            this.lblGradeID.TabIndex = 4;
            this.lblGradeID.Text = "年  级";
            this.lblGradeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSex
            // 
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSex.Location = new System.Drawing.Point(12, 66);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(90, 23);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "性  别";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStuName
            // 
            this.lblStuName.BackColor = System.Drawing.Color.Transparent;
            this.lblStuName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuName.Location = new System.Drawing.Point(12, 29);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(90, 23);
            this.lblStuName.TabIndex = 2;
            this.lblStuName.Text = "姓  名";
            this.lblStuName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(206, 472);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保  存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(307, 472);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清  空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmAddStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 497);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbBasic);
            this.Controls.Add(this.gbRegion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmAddStu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增学员信息";
            this.Load += new System.EventHandler(this.FrmAddStu_Load);
            this.gbRegion.ResumeLayout(false);
            this.gbRegion.PerformLayout();
            this.gbBasic.ResumeLayout(false);
            this.gbBasic.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegion;
        private System.Windows.Forms.GroupBox gbBasic;
        private System.Windows.Forms.Label lblStuNO;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblPwdSure;
        private System.Windows.Forms.TextBox txtStuNO;
        private System.Windows.Forms.TextBox txtPwdSure;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblGradeID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBornDate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbGradeID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.DateTimePicker dtpBornDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}