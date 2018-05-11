namespace Demo3
{
    partial class FrmTestJob
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
            this.gbTestJob = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSure = new System.Windows.Forms.Button();
            this.txtDayNum = new System.Windows.Forms.TextBox();
            this.txtBugNum = new System.Windows.Forms.TextBox();
            this.txtCaseNum = new System.Windows.Forms.TextBox();
            this.lblDayNum = new System.Windows.Forms.Label();
            this.lblBugNum = new System.Windows.Forms.Label();
            this.lblCaseNum = new System.Windows.Forms.Label();
            this.gbTestJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTestJob
            // 
            this.gbTestJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTestJob.Controls.Add(this.btnCancel);
            this.gbTestJob.Controls.Add(this.btnSure);
            this.gbTestJob.Controls.Add(this.txtDayNum);
            this.gbTestJob.Controls.Add(this.txtBugNum);
            this.gbTestJob.Controls.Add(this.txtCaseNum);
            this.gbTestJob.Controls.Add(this.lblDayNum);
            this.gbTestJob.Controls.Add(this.lblBugNum);
            this.gbTestJob.Controls.Add(this.lblCaseNum);
            this.gbTestJob.Location = new System.Drawing.Point(13, 13);
            this.gbTestJob.Name = "gbTestJob";
            this.gbTestJob.Size = new System.Drawing.Size(359, 237);
            this.gbTestJob.TabIndex = 1;
            this.gbTestJob.TabStop = false;
            this.gbTestJob.Text = "填写工作指标";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(266, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSure
            // 
            this.btnSure.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSure.Location = new System.Drawing.Point(162, 199);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 22);
            this.btnSure.TabIndex = 6;
            this.btnSure.Text = "提  交";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // txtDayNum
            // 
            this.txtDayNum.Location = new System.Drawing.Point(162, 149);
            this.txtDayNum.Name = "txtDayNum";
            this.txtDayNum.Size = new System.Drawing.Size(179, 21);
            this.txtDayNum.TabIndex = 5;
            // 
            // txtBugNum
            // 
            this.txtBugNum.Location = new System.Drawing.Point(162, 96);
            this.txtBugNum.Name = "txtBugNum";
            this.txtBugNum.Size = new System.Drawing.Size(179, 21);
            this.txtBugNum.TabIndex = 4;
            // 
            // txtCaseNum
            // 
            this.txtCaseNum.Location = new System.Drawing.Point(162, 43);
            this.txtCaseNum.Name = "txtCaseNum";
            this.txtCaseNum.Size = new System.Drawing.Size(179, 21);
            this.txtCaseNum.TabIndex = 3;
            // 
            // lblDayNum
            // 
            this.lblDayNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDayNum.Location = new System.Drawing.Point(7, 148);
            this.lblDayNum.Name = "lblDayNum";
            this.lblDayNum.Size = new System.Drawing.Size(134, 23);
            this.lblDayNum.TabIndex = 2;
            this.lblDayNum.Text = "测试工作日";
            this.lblDayNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBugNum
            // 
            this.lblBugNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBugNum.Location = new System.Drawing.Point(7, 95);
            this.lblBugNum.Name = "lblBugNum";
            this.lblBugNum.Size = new System.Drawing.Size(134, 23);
            this.lblBugNum.TabIndex = 1;
            this.lblBugNum.Text = "测试BUG个数";
            this.lblBugNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCaseNum
            // 
            this.lblCaseNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCaseNum.Location = new System.Drawing.Point(7, 42);
            this.lblCaseNum.Name = "lblCaseNum";
            this.lblCaseNum.Size = new System.Drawing.Size(134, 23);
            this.lblCaseNum.TabIndex = 0;
            this.lblCaseNum.Text = "测试用例个数";
            this.lblCaseNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmTestJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.gbTestJob);
            this.Name = "FrmTestJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工作类型—测试";
            this.gbTestJob.ResumeLayout(false);
            this.gbTestJob.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTestJob;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.TextBox txtDayNum;
        private System.Windows.Forms.TextBox txtBugNum;
        private System.Windows.Forms.TextBox txtCaseNum;
        private System.Windows.Forms.Label lblDayNum;
        private System.Windows.Forms.Label lblBugNum;
        private System.Windows.Forms.Label lblCaseNum;
    }
}