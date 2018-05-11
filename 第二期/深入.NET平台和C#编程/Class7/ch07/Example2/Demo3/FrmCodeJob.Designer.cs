namespace Demo3
{
    partial class FrmCodeJob
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
            this.gbCodeJob = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSure = new System.Windows.Forms.Button();
            this.txtDayNum = new System.Windows.Forms.TextBox();
            this.txtBugNum = new System.Windows.Forms.TextBox();
            this.txtCodeNum = new System.Windows.Forms.TextBox();
            this.lblDayNum = new System.Windows.Forms.Label();
            this.lblBugNum = new System.Windows.Forms.Label();
            this.lblCodeNum = new System.Windows.Forms.Label();
            this.gbCodeJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCodeJob
            // 
            this.gbCodeJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCodeJob.Controls.Add(this.btnCancel);
            this.gbCodeJob.Controls.Add(this.btnSure);
            this.gbCodeJob.Controls.Add(this.txtDayNum);
            this.gbCodeJob.Controls.Add(this.txtBugNum);
            this.gbCodeJob.Controls.Add(this.txtCodeNum);
            this.gbCodeJob.Controls.Add(this.lblDayNum);
            this.gbCodeJob.Controls.Add(this.lblBugNum);
            this.gbCodeJob.Controls.Add(this.lblCodeNum);
            this.gbCodeJob.Location = new System.Drawing.Point(13, 13);
            this.gbCodeJob.Name = "gbCodeJob";
            this.gbCodeJob.Size = new System.Drawing.Size(359, 237);
            this.gbCodeJob.TabIndex = 2;
            this.gbCodeJob.TabStop = false;
            this.gbCodeJob.Text = "填写工作指标";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(271, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSure
            // 
            this.btnSure.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSure.Location = new System.Drawing.Point(167, 186);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 22);
            this.btnSure.TabIndex = 14;
            this.btnSure.Text = "提  交";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // txtDayNum
            // 
            this.txtDayNum.Location = new System.Drawing.Point(167, 136);
            this.txtDayNum.Name = "txtDayNum";
            this.txtDayNum.Size = new System.Drawing.Size(179, 21);
            this.txtDayNum.TabIndex = 13;
            // 
            // txtBugNum
            // 
            this.txtBugNum.Location = new System.Drawing.Point(167, 83);
            this.txtBugNum.Name = "txtBugNum";
            this.txtBugNum.Size = new System.Drawing.Size(179, 21);
            this.txtBugNum.TabIndex = 12;
            // 
            // txtCodeNum
            // 
            this.txtCodeNum.Location = new System.Drawing.Point(167, 30);
            this.txtCodeNum.Name = "txtCodeNum";
            this.txtCodeNum.Size = new System.Drawing.Size(179, 21);
            this.txtCodeNum.TabIndex = 11;
            // 
            // lblDayNum
            // 
            this.lblDayNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDayNum.Location = new System.Drawing.Point(12, 135);
            this.lblDayNum.Name = "lblDayNum";
            this.lblDayNum.Size = new System.Drawing.Size(134, 23);
            this.lblDayNum.TabIndex = 10;
            this.lblDayNum.Text = "编码工作日";
            this.lblDayNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBugNum
            // 
            this.lblBugNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBugNum.Location = new System.Drawing.Point(12, 82);
            this.lblBugNum.Name = "lblBugNum";
            this.lblBugNum.Size = new System.Drawing.Size(134, 23);
            this.lblBugNum.TabIndex = 9;
            this.lblBugNum.Text = "编码BUG个数";
            this.lblBugNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCodeNum
            // 
            this.lblCodeNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCodeNum.Location = new System.Drawing.Point(12, 29);
            this.lblCodeNum.Name = "lblCodeNum";
            this.lblCodeNum.Size = new System.Drawing.Size(134, 23);
            this.lblCodeNum.TabIndex = 8;
            this.lblCodeNum.Text = "有效代码行数";
            this.lblCodeNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmCodeJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.gbCodeJob);
            this.Name = "FrmCodeJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工作类型—编码";
            this.gbCodeJob.ResumeLayout(false);
            this.gbCodeJob.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCodeJob;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.TextBox txtDayNum;
        private System.Windows.Forms.TextBox txtBugNum;
        private System.Windows.Forms.TextBox txtCodeNum;
        private System.Windows.Forms.Label lblDayNum;
        private System.Windows.Forms.Label lblBugNum;
        private System.Windows.Forms.Label lblCodeNum;
    }
}