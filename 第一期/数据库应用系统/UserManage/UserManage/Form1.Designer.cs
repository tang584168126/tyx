namespace UserManage
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
            this.lalMain = new System.Windows.Forms.Label();
            this.lalID = new System.Windows.Forms.Label();
            this.lalPwd = new System.Windows.Forms.Label();
            this.lalType = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lilID = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lalMain
            // 
            this.lalMain.AutoSize = true;
            this.lalMain.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalMain.Location = new System.Drawing.Point(163, 25);
            this.lalMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalMain.Name = "lalMain";
            this.lalMain.Size = new System.Drawing.Size(135, 20);
            this.lalMain.TabIndex = 0;
            this.lalMain.Text = "系统登录管理";
            // 
            // lalID
            // 
            this.lalID.AutoSize = true;
            this.lalID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalID.Location = new System.Drawing.Point(22, 71);
            this.lalID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalID.Name = "lalID";
            this.lalID.Size = new System.Drawing.Size(76, 16);
            this.lalID.TabIndex = 1;
            this.lalID.Text = "用户编号";
            // 
            // lalPwd
            // 
            this.lalPwd.AutoSize = true;
            this.lalPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalPwd.Location = new System.Drawing.Point(22, 109);
            this.lalPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalPwd.Name = "lalPwd";
            this.lalPwd.Size = new System.Drawing.Size(76, 16);
            this.lalPwd.TabIndex = 2;
            this.lalPwd.Text = "用户密码";
            // 
            // lalType
            // 
            this.lalType.AutoSize = true;
            this.lalType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalType.Location = new System.Drawing.Point(22, 148);
            this.lalType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lalType.Name = "lalType";
            this.lalType.Size = new System.Drawing.Size(76, 16);
            this.lalType.TabIndex = 3;
            this.lalType.Text = "登录类型";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(117, 68);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.MaxLength = 20;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(247, 26);
            this.txtID.TabIndex = 4;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(117, 106);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPwd.MaxLength = 50;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(247, 26);
            this.txtPwd.TabIndex = 5;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "临时账户",
            "普通用户",
            "系统管理员"});
            this.cmbType.Location = new System.Drawing.Point(117, 148);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(247, 24);
            this.cmbType.TabIndex = 6;
            // 
            // lilID
            // 
            this.lilID.AutoSize = true;
            this.lilID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lilID.Location = new System.Drawing.Point(372, 71);
            this.lilID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lilID.Name = "lilID";
            this.lilID.Size = new System.Drawing.Size(93, 16);
            this.lilID.TabIndex = 7;
            this.lilID.TabStop = true;
            this.lilID.Text = "注册新用户";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(117, 199);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 31);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "登 陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(237, 199);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 31);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lilID);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lalType);
            this.Controls.Add(this.lalPwd);
            this.Controls.Add(this.lalID);
            this.Controls.Add(this.lalMain);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalMain;
        private System.Windows.Forms.Label lalID;
        private System.Windows.Forms.Label lalPwd;
        private System.Windows.Forms.Label lalType;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.LinkLabel lilID;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}

