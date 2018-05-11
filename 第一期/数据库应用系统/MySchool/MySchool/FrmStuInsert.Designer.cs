namespace MySchool
{
    partial class FrmStuInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStuInsert));
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.txtPwdSure = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.lalPwdSure = new System.Windows.Forms.Label();
            this.lalPwd = new System.Windows.Forms.Label();
            this.lalStuNO = new System.Windows.Forms.Label();
            this.gbBasic = new System.Windows.Forms.GroupBox();
            this.dtpBornDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.cmbGradeID = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lalEmail = new System.Windows.Forms.Label();
            this.lalBorder = new System.Windows.Forms.Label();
            this.lalAdress = new System.Windows.Forms.Label();
            this.lalPhone = new System.Windows.Forms.Label();
            this.lalGrade = new System.Windows.Forms.Label();
            this.lalSex = new System.Windows.Forms.Label();
            this.lalName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            this.gbBasic.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLogin.Controls.Add(this.txtPwdSure);
            this.gbLogin.Controls.Add(this.txtPwd);
            this.gbLogin.Controls.Add(this.txtStuNo);
            this.gbLogin.Controls.Add(this.lalPwdSure);
            this.gbLogin.Controls.Add(this.lalPwd);
            this.gbLogin.Controls.Add(this.lalStuNO);
            this.gbLogin.Location = new System.Drawing.Point(12, 24);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(410, 117);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "用户注册信息";
            // 
            // txtPwdSure
            // 
            this.txtPwdSure.Location = new System.Drawing.Point(114, 88);
            this.txtPwdSure.MaxLength = 20;
            this.txtPwdSure.Name = "txtPwdSure";
            this.txtPwdSure.PasswordChar = '*';
            this.txtPwdSure.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPwdSure.Size = new System.Drawing.Size(246, 21);
            this.txtPwdSure.TabIndex = 6;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(114, 55);
            this.txtPwd.MaxLength = 20;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPwd.Size = new System.Drawing.Size(246, 21);
            this.txtPwd.TabIndex = 5;
            // 
            // txtStuNo
            // 
            this.txtStuNo.Location = new System.Drawing.Point(114, 22);
            this.txtStuNo.MaxLength = 18;
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStuNo.Size = new System.Drawing.Size(246, 21);
            this.txtStuNo.TabIndex = 4;
            // 
            // lalPwdSure
            // 
            this.lalPwdSure.BackColor = System.Drawing.Color.Transparent;
            this.lalPwdSure.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalPwdSure.Location = new System.Drawing.Point(6, 88);
            this.lalPwdSure.Name = "lalPwdSure";
            this.lalPwdSure.Size = new System.Drawing.Size(95, 23);
            this.lalPwdSure.TabIndex = 3;
            this.lalPwdSure.Text = "确认密码:";
            this.lalPwdSure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lalPwd
            // 
            this.lalPwd.AutoSize = true;
            this.lalPwd.BackColor = System.Drawing.Color.Transparent;
            this.lalPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalPwd.Location = new System.Drawing.Point(41, 54);
            this.lalPwd.Name = "lalPwd";
            this.lalPwd.Size = new System.Drawing.Size(51, 16);
            this.lalPwd.TabIndex = 2;
            this.lalPwd.Text = "密码:";
            this.lalPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lalStuNO
            // 
            this.lalStuNO.AutoSize = true;
            this.lalStuNO.BackColor = System.Drawing.Color.Transparent;
            this.lalStuNO.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalStuNO.Location = new System.Drawing.Point(41, 21);
            this.lalStuNO.Name = "lalStuNO";
            this.lalStuNO.Size = new System.Drawing.Size(59, 16);
            this.lalStuNO.TabIndex = 1;
            this.lalStuNO.Text = "学号：";
            this.lalStuNO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbBasic
            // 
            this.gbBasic.Controls.Add(this.dtpBornDate);
            this.gbBasic.Controls.Add(this.panel1);
            this.gbBasic.Controls.Add(this.cmbGradeID);
            this.gbBasic.Controls.Add(this.txtEmail);
            this.gbBasic.Controls.Add(this.txtAdress);
            this.gbBasic.Controls.Add(this.txtPhone);
            this.gbBasic.Controls.Add(this.txtName);
            this.gbBasic.Controls.Add(this.lalEmail);
            this.gbBasic.Controls.Add(this.lalBorder);
            this.gbBasic.Controls.Add(this.lalAdress);
            this.gbBasic.Controls.Add(this.lalPhone);
            this.gbBasic.Controls.Add(this.lalGrade);
            this.gbBasic.Controls.Add(this.lalSex);
            this.gbBasic.Controls.Add(this.lalName);
            this.gbBasic.Location = new System.Drawing.Point(12, 166);
            this.gbBasic.Name = "gbBasic";
            this.gbBasic.Size = new System.Drawing.Size(410, 304);
            this.gbBasic.TabIndex = 1;
            this.gbBasic.TabStop = false;
            this.gbBasic.Text = "用户基本信息";
            // 
            // dtpBornDate
            // 
            this.dtpBornDate.Location = new System.Drawing.Point(105, 221);
            this.dtpBornDate.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtpBornDate.Name = "dtpBornDate";
            this.dtpBornDate.Size = new System.Drawing.Size(246, 21);
            this.dtpBornDate.TabIndex = 15;
            this.dtpBornDate.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtFemale);
            this.panel1.Controls.Add(this.rbtMale);
            this.panel1.Location = new System.Drawing.Point(105, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 16);
            this.panel1.TabIndex = 14;
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(64, 0);
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
            this.rbtMale.Location = new System.Drawing.Point(4, 0);
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
            this.cmbGradeID.Location = new System.Drawing.Point(105, 116);
            this.cmbGradeID.Name = "cmbGradeID";
            this.cmbGradeID.Size = new System.Drawing.Size(246, 20);
            this.cmbGradeID.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 264);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEmail.Size = new System.Drawing.Size(246, 21);
            this.txtEmail.TabIndex = 12;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(105, 191);
            this.txtAdress.MaxLength = 255;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAdress.Size = new System.Drawing.Size(246, 21);
            this.txtAdress.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(105, 154);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPhone.Size = new System.Drawing.Size(246, 21);
            this.txtPhone.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 37);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtName.Size = new System.Drawing.Size(246, 21);
            this.txtName.TabIndex = 9;
            // 
            // lalEmail
            // 
            this.lalEmail.AutoSize = true;
            this.lalEmail.BackColor = System.Drawing.Color.Transparent;
            this.lalEmail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalEmail.Location = new System.Drawing.Point(22, 264);
            this.lalEmail.Name = "lalEmail";
            this.lalEmail.Size = new System.Drawing.Size(70, 16);
            this.lalEmail.TabIndex = 8;
            this.lalEmail.Text = "Email：";
            this.lalEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lalBorder
            // 
            this.lalBorder.AutoSize = true;
            this.lalBorder.BackColor = System.Drawing.Color.Transparent;
            this.lalBorder.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalBorder.Location = new System.Drawing.Point(-1, 227);
            this.lalBorder.Name = "lalBorder";
            this.lalBorder.Size = new System.Drawing.Size(93, 16);
            this.lalBorder.TabIndex = 7;
            this.lalBorder.Text = "出生日期：";
            this.lalBorder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lalAdress
            // 
            this.lalAdress.AutoSize = true;
            this.lalAdress.BackColor = System.Drawing.Color.Transparent;
            this.lalAdress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalAdress.Location = new System.Drawing.Point(33, 190);
            this.lalAdress.Name = "lalAdress";
            this.lalAdress.Size = new System.Drawing.Size(59, 16);
            this.lalAdress.TabIndex = 6;
            this.lalAdress.Text = "地址：";
            this.lalAdress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lalPhone
            // 
            this.lalPhone.AutoSize = true;
            this.lalPhone.BackColor = System.Drawing.Color.Transparent;
            this.lalPhone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalPhone.Location = new System.Drawing.Point(33, 153);
            this.lalPhone.Name = "lalPhone";
            this.lalPhone.Size = new System.Drawing.Size(59, 16);
            this.lalPhone.TabIndex = 5;
            this.lalPhone.Text = "电话：";
            this.lalPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lalGrade
            // 
            this.lalGrade.AutoSize = true;
            this.lalGrade.BackColor = System.Drawing.Color.Transparent;
            this.lalGrade.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalGrade.Location = new System.Drawing.Point(33, 116);
            this.lalGrade.Name = "lalGrade";
            this.lalGrade.Size = new System.Drawing.Size(59, 16);
            this.lalGrade.TabIndex = 4;
            this.lalGrade.Text = "年级：";
            this.lalGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lalSex
            // 
            this.lalSex.AutoSize = true;
            this.lalSex.BackColor = System.Drawing.Color.Transparent;
            this.lalSex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalSex.Location = new System.Drawing.Point(33, 79);
            this.lalSex.Name = "lalSex";
            this.lalSex.Size = new System.Drawing.Size(59, 16);
            this.lalSex.TabIndex = 3;
            this.lalSex.Text = "性别：";
            this.lalSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lalName
            // 
            this.lalName.AutoSize = true;
            this.lalName.BackColor = System.Drawing.Color.Transparent;
            this.lalName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalName.Location = new System.Drawing.Point(33, 42);
            this.lalName.Name = "lalName";
            this.lalName.Size = new System.Drawing.Size(59, 16);
            this.lalName.TabIndex = 2;
            this.lalName.Text = "姓名：";
            this.lalName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(317, 477);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "清 空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(236, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmStuInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 512);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbBasic);
            this.Controls.Add(this.gbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStuInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增学员";
            this.Load += new System.EventHandler(this.FrmStuInsert_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbBasic.ResumeLayout(false);
            this.gbBasic.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label lalStuNO;
        private System.Windows.Forms.Label lalPwdSure;
        private System.Windows.Forms.Label lalPwd;
        private System.Windows.Forms.TextBox txtPwdSure;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.GroupBox gbBasic;
        private System.Windows.Forms.Label lalBorder;
        private System.Windows.Forms.Label lalAdress;
        private System.Windows.Forms.Label lalPhone;
        private System.Windows.Forms.Label lalGrade;
        private System.Windows.Forms.Label lalSex;
        private System.Windows.Forms.Label lalName;
        private System.Windows.Forms.ComboBox cmbGradeID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lalEmail;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.DateTimePicker dtpBornDate;
    }
}