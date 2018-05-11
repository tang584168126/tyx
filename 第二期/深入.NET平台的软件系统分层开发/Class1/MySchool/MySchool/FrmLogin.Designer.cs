namespace MySchool
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
            this.lalStuNO = new System.Windows.Forms.Label();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.lalStuPwd = new System.Windows.Forms.Label();
            this.lalStuStyle = new System.Windows.Forms.Label();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lalStuNO
            // 
            this.lalStuNO.BackColor = System.Drawing.Color.Transparent;
            this.lalStuNO.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalStuNO.Location = new System.Drawing.Point(170, 156);
            this.lalStuNO.Name = "lalStuNO";
            this.lalStuNO.Size = new System.Drawing.Size(75, 23);
            this.lalStuNO.TabIndex = 1;
            this.lalStuNO.Text = "用户名:";
            this.lalStuNO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStuNo
            // 
            this.txtStuNo.Location = new System.Drawing.Point(262, 156);
            this.txtStuNo.MaxLength = 10;
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStuNo.Size = new System.Drawing.Size(149, 21);
            this.txtStuNo.TabIndex = 4;
            // 
            // lalStuPwd
            // 
            this.lalStuPwd.BackColor = System.Drawing.Color.Transparent;
            this.lalStuPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalStuPwd.Location = new System.Drawing.Point(170, 190);
            this.lalStuPwd.Name = "lalStuPwd";
            this.lalStuPwd.Size = new System.Drawing.Size(90, 23);
            this.lalStuPwd.TabIndex = 5;
            this.lalStuPwd.Text = "密  码：";
            this.lalStuPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lalStuStyle
            // 
            this.lalStuStyle.BackColor = System.Drawing.Color.Transparent;
            this.lalStuStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalStuStyle.Location = new System.Drawing.Point(170, 223);
            this.lalStuStyle.Name = "lalStuStyle";
            this.lalStuStyle.Size = new System.Drawing.Size(90, 23);
            this.lalStuStyle.TabIndex = 6;
            this.lalStuStyle.Text = "登录类型:";
            this.lalStuStyle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Location = new System.Drawing.Point(262, 190);
            this.txtLoginPwd.MaxLength = 20;
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLoginPwd.Size = new System.Drawing.Size(149, 21);
            this.txtLoginPwd.TabIndex = 7;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "管理员",
            "普通用户"});
            this.cmbType.Location = new System.Drawing.Point(262, 227);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(149, 20);
            this.cmbType.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(262, 253);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "登 陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(343, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 312);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.lalStuStyle);
            this.Controls.Add(this.lalStuPwd);
            this.Controls.Add(this.txtStuNo);
            this.Controls.Add(this.lalStuNO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySchool学员管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalStuNO;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.Label lalStuPwd;
        private System.Windows.Forms.Label lalStuStyle;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}

