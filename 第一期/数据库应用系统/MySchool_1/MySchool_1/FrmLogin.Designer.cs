namespace MySchool_1
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblStuNo = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblStye = new System.Windows.Forms.Label();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCansole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStuNo
            // 
            this.lblStuNo.AutoSize = true;
            this.lblStuNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuNo.Location = new System.Drawing.Point(178, 162);
            this.lblStuNo.Name = "lblStuNo";
            this.lblStuNo.Size = new System.Drawing.Size(94, 16);
            this.lblStuNo.TabIndex = 0;
            this.lblStuNo.Text = "用 户 名：";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(178, 197);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(95, 16);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "密    码：";
            // 
            // lblStye
            // 
            this.lblStye.AutoSize = true;
            this.lblStye.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStye.Location = new System.Drawing.Point(178, 226);
            this.lblStye.Name = "lblStye";
            this.lblStye.Size = new System.Drawing.Size(85, 16);
            this.lblStye.TabIndex = 2;
            this.lblStye.Text = "登录类型:";
            // 
            // txtStuNo
            // 
            this.txtStuNo.Location = new System.Drawing.Point(279, 162);
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.Size = new System.Drawing.Size(162, 21);
            this.txtStuNo.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(279, 192);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(162, 21);
            this.txtPwd.TabIndex = 4;
            // 
            // cmbStyle
            // 
            this.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Items.AddRange(new object[] {
            "管理员",
            "普通用户"});
            this.cmbStyle.Location = new System.Drawing.Point(279, 221);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(162, 20);
            this.cmbStyle.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(279, 261);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "登 录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCansole
            // 
            this.btnCansole.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCansole.Location = new System.Drawing.Point(366, 261);
            this.btnCansole.Name = "btnCansole";
            this.btnCansole.Size = new System.Drawing.Size(75, 23);
            this.btnCansole.TabIndex = 7;
            this.btnCansole.Text = "取消";
            this.btnCansole.UseVisualStyleBackColor = true;
            this.btnCansole.Click += new System.EventHandler(this.btnCansole_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 317);
            this.Controls.Add(this.btnCansole);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbStyle);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtStuNo);
            this.Controls.Add(this.lblStye);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblStuNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySchool学院管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStuNo;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblStye;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.ComboBox cmbStyle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCansole;
    }
}

