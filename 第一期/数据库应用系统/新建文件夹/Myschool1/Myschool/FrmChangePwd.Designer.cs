namespace Myschool
{
    partial class FrmChangePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangePwd));
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.lblNewPwd1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnconcel = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPwd.Location = new System.Drawing.Point(54, 224);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(112, 14);
            this.lblPwd.TabIndex = 0;
            this.lblPwd.Text = "请输入原密码：";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPwd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNewPwd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNewPwd.Location = new System.Drawing.Point(54, 295);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(112, 14);
            this.lblNewPwd.TabIndex = 1;
            this.lblNewPwd.Text = "请输入新密码：";
            // 
            // lblNewPwd1
            // 
            this.lblNewPwd1.AutoSize = true;
            this.lblNewPwd1.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPwd1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNewPwd1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNewPwd1.Location = new System.Drawing.Point(39, 367);
            this.lblNewPwd1.Name = "lblNewPwd1";
            this.lblNewPwd1.Size = new System.Drawing.Size(127, 14);
            this.lblNewPwd1.TabIndex = 2;
            this.lblNewPwd1.Text = "再次输入新密码：";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(175, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnconcel
            // 
            this.btnconcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnconcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnconcel.BackgroundImage")));
            this.btnconcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnconcel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnconcel.Location = new System.Drawing.Point(330, 436);
            this.btnconcel.Name = "btnconcel";
            this.btnconcel.Size = new System.Drawing.Size(75, 23);
            this.btnconcel.TabIndex = 4;
            this.btnconcel.Text = "取消";
            this.btnconcel.UseVisualStyleBackColor = true;
            this.btnconcel.Click += new System.EventHandler(this.btnconcel_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(184, 217);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(183, 21);
            this.txtPwd.TabIndex = 5;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(184, 294);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(183, 21);
            this.txtNewPwd.TabIndex = 6;
            // 
            // txtNewPwd1
            // 
            this.txtNewPwd1.Location = new System.Drawing.Point(184, 366);
            this.txtNewPwd1.Name = "txtNewPwd1";
            this.txtNewPwd1.PasswordChar = '*';
            this.txtNewPwd1.Size = new System.Drawing.Size(183, 21);
            this.txtNewPwd1.TabIndex = 7;
            // 
            // FrmChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 551);
            this.Controls.Add(this.txtNewPwd1);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.btnconcel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNewPwd1);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.lblPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Label lblNewPwd1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnconcel;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtNewPwd1;
    }
}