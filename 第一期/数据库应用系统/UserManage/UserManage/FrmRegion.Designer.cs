namespace UserManage
{
    partial class FrmRegion
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
            this.lalLogin = new System.Windows.Forms.Label();
            this.lalID = new System.Windows.Forms.Label();
            this.lalType = new System.Windows.Forms.Label();
            this.lalPwd2 = new System.Windows.Forms.Label();
            this.lalPwd = new System.Windows.Forms.Label();
            this.lalName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lala = new System.Windows.Forms.Label();
            this.lalb = new System.Windows.Forms.Label();
            this.btnLogion = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lalLogin
            // 
            this.lalLogin.AutoSize = true;
            this.lalLogin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalLogin.Location = new System.Drawing.Point(180, 9);
            this.lalLogin.Name = "lalLogin";
            this.lalLogin.Size = new System.Drawing.Size(110, 16);
            this.lalLogin.TabIndex = 0;
            this.lalLogin.Text = "系统注册管理";
            // 
            // lalID
            // 
            this.lalID.AutoSize = true;
            this.lalID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalID.Location = new System.Drawing.Point(74, 42);
            this.lalID.Name = "lalID";
            this.lalID.Size = new System.Drawing.Size(76, 16);
            this.lalID.TabIndex = 1;
            this.lalID.Text = "用户编号";
            // 
            // lalType
            // 
            this.lalType.AutoSize = true;
            this.lalType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalType.Location = new System.Drawing.Point(74, 165);
            this.lalType.Name = "lalType";
            this.lalType.Size = new System.Drawing.Size(76, 16);
            this.lalType.TabIndex = 2;
            this.lalType.Text = "用户类型";
            // 
            // lalPwd2
            // 
            this.lalPwd2.AutoSize = true;
            this.lalPwd2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalPwd2.Location = new System.Drawing.Point(74, 132);
            this.lalPwd2.Name = "lalPwd2";
            this.lalPwd2.Size = new System.Drawing.Size(76, 16);
            this.lalPwd2.TabIndex = 3;
            this.lalPwd2.Text = "确认密码";
            // 
            // lalPwd
            // 
            this.lalPwd.AutoSize = true;
            this.lalPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalPwd.Location = new System.Drawing.Point(74, 104);
            this.lalPwd.Name = "lalPwd";
            this.lalPwd.Size = new System.Drawing.Size(76, 16);
            this.lalPwd.TabIndex = 4;
            this.lalPwd.Text = "用户密码";
            // 
            // lalName
            // 
            this.lalName.AutoSize = true;
            this.lalName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalName.Location = new System.Drawing.Point(74, 74);
            this.lalName.Name = "lalName";
            this.lalName.Size = new System.Drawing.Size(76, 16);
            this.lalName.TabIndex = 5;
            this.lalName.Text = "用户姓名";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(157, 42);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(149, 21);
            this.txtID.TabIndex = 6;
            this.txtID.Text = "自动编号";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 75);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 21);
            this.txtName.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 105);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(149, 21);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 133);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(149, 21);
            this.textBox2.TabIndex = 9;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "临时账户",
            "普通用户",
            "系统管理员"});
            this.cmbType.Location = new System.Drawing.Point(157, 160);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(148, 20);
            this.cmbType.TabIndex = 10;
            // 
            // lala
            // 
            this.lala.AutoSize = true;
            this.lala.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lala.Location = new System.Drawing.Point(311, 105);
            this.lala.Name = "lala";
            this.lala.Size = new System.Drawing.Size(143, 12);
            this.lala.TabIndex = 11;
            this.lala.Text = "(密码长度不能小于6位)";
            // 
            // lalb
            // 
            this.lalb.AutoSize = true;
            this.lalb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalb.Location = new System.Drawing.Point(311, 133);
            this.lalb.Name = "lalb";
            this.lalb.Size = new System.Drawing.Size(123, 12);
            this.lalb.TabIndex = 12;
            this.lalb.Text = "(两次密码必须相等)";
            // 
            // btnLogion
            // 
            this.btnLogion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogion.Location = new System.Drawing.Point(156, 201);
            this.btnLogion.Name = "btnLogion";
            this.btnLogion.Size = new System.Drawing.Size(75, 23);
            this.btnLogion.TabIndex = 13;
            this.btnLogion.Text = "注 册";
            this.btnLogion.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(238, 201);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "关 闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogion);
            this.Controls.Add(this.lalb);
            this.Controls.Add(this.lala);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lalName);
            this.Controls.Add(this.lalPwd);
            this.Controls.Add(this.lalPwd2);
            this.Controls.Add(this.lalType);
            this.Controls.Add(this.lalID);
            this.Controls.Add(this.lalLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegion_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalLogin;
        private System.Windows.Forms.Label lalID;
        private System.Windows.Forms.Label lalType;
        private System.Windows.Forms.Label lalPwd2;
        private System.Windows.Forms.Label lalPwd;
        private System.Windows.Forms.Label lalName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lala;
        private System.Windows.Forms.Label lalb;
        private System.Windows.Forms.Button btnLogion;
        private System.Windows.Forms.Button btnClose;
    }
}