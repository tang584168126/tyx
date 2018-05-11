namespace MySchool
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
            this.lalIntrinsicPwd = new System.Windows.Forms.Label();
            this.lalNewPwd = new System.Windows.Forms.Label();
            this.lalAffirmPwd = new System.Windows.Forms.Label();
            this.txtIntrinsicPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtAffirmPwd = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lalIntrinsicPwd
            // 
            this.lalIntrinsicPwd.AutoSize = true;
            this.lalIntrinsicPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalIntrinsicPwd.Location = new System.Drawing.Point(48, 34);
            this.lalIntrinsicPwd.Name = "lalIntrinsicPwd";
            this.lalIntrinsicPwd.Size = new System.Drawing.Size(76, 16);
            this.lalIntrinsicPwd.TabIndex = 0;
            this.lalIntrinsicPwd.Text = "原密码：";
            // 
            // lalNewPwd
            // 
            this.lalNewPwd.AutoSize = true;
            this.lalNewPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalNewPwd.Location = new System.Drawing.Point(48, 84);
            this.lalNewPwd.Name = "lalNewPwd";
            this.lalNewPwd.Size = new System.Drawing.Size(68, 16);
            this.lalNewPwd.TabIndex = 1;
            this.lalNewPwd.Text = "新密码:";
            // 
            // lalAffirmPwd
            // 
            this.lalAffirmPwd.AutoSize = true;
            this.lalAffirmPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalAffirmPwd.Location = new System.Drawing.Point(31, 138);
            this.lalAffirmPwd.Name = "lalAffirmPwd";
            this.lalAffirmPwd.Size = new System.Drawing.Size(93, 16);
            this.lalAffirmPwd.TabIndex = 2;
            this.lalAffirmPwd.Text = "确认密码：";
            // 
            // txtIntrinsicPwd
            // 
            this.txtIntrinsicPwd.Location = new System.Drawing.Point(148, 28);
            this.txtIntrinsicPwd.MaxLength = 50;
            this.txtIntrinsicPwd.Name = "txtIntrinsicPwd";
            this.txtIntrinsicPwd.Size = new System.Drawing.Size(208, 21);
            this.txtIntrinsicPwd.TabIndex = 3;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(148, 84);
            this.txtNewPwd.MaxLength = 50;
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(208, 21);
            this.txtNewPwd.TabIndex = 4;
            // 
            // txtAffirmPwd
            // 
            this.txtAffirmPwd.Location = new System.Drawing.Point(148, 139);
            this.txtAffirmPwd.MaxLength = 50;
            this.txtAffirmPwd.Name = "txtAffirmPwd";
            this.txtAffirmPwd.Size = new System.Drawing.Size(208, 21);
            this.txtAffirmPwd.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(148, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(254, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAffirmPwd);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtIntrinsicPwd);
            this.Controls.Add(this.lalAffirmPwd);
            this.Controls.Add(this.lalNewPwd);
            this.Controls.Add(this.lalIntrinsicPwd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChangePwd";
            this.Text = "密码修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalIntrinsicPwd;
        private System.Windows.Forms.Label lalNewPwd;
        private System.Windows.Forms.Label lalAffirmPwd;
        private System.Windows.Forms.TextBox txtIntrinsicPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtAffirmPwd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}