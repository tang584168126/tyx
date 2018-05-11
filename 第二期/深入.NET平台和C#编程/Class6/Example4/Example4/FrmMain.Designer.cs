namespace Example4
{
    partial class FrmMain
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
            this.gbText = new System.Windows.Forms.GroupBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.txtDigit2 = new System.Windows.Forms.TextBox();
            this.cmbSign = new System.Windows.Forms.ComboBox();
            this.txtDigit1 = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbText.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbText
            // 
            this.gbText.Controls.Add(this.btnResult);
            this.gbText.Controls.Add(this.txtDigit2);
            this.gbText.Controls.Add(this.cmbSign);
            this.gbText.Controls.Add(this.txtDigit1);
            this.gbText.Location = new System.Drawing.Point(41, 12);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(450, 62);
            this.gbText.TabIndex = 0;
            this.gbText.TabStop = false;
            this.gbText.Text = "计算";
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnResult.Location = new System.Drawing.Point(373, 18);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "计算";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txtDigit2
            // 
            this.txtDigit2.Location = new System.Drawing.Point(247, 21);
            this.txtDigit2.Name = "txtDigit2";
            this.txtDigit2.Size = new System.Drawing.Size(100, 21);
            this.txtDigit2.TabIndex = 2;
            // 
            // cmbSign
            // 
            this.cmbSign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSign.FormattingEnabled = true;
            this.cmbSign.Location = new System.Drawing.Point(159, 21);
            this.cmbSign.Name = "cmbSign";
            this.cmbSign.Size = new System.Drawing.Size(62, 20);
            this.cmbSign.TabIndex = 1;
            // 
            // txtDigit1
            // 
            this.txtDigit1.Location = new System.Drawing.Point(40, 21);
            this.txtDigit1.Name = "txtDigit1";
            this.txtDigit1.Size = new System.Drawing.Size(100, 21);
            this.txtDigit1.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblText.Location = new System.Drawing.Point(109, 92);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(76, 16);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "计算结果";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(206, 92);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(86, 16);
            this.lblResult.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 130);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.gbText);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbText.ResumeLayout(false);
            this.gbText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbText;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txtDigit2;
        private System.Windows.Forms.ComboBox cmbSign;
        private System.Windows.Forms.TextBox txtDigit1;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblResult;
    }
}

