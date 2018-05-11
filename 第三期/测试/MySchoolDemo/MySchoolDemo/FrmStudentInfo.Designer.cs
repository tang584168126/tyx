namespace MySchoolDemo
{
    partial class FrmStudentInfo
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
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.lblStuNum = new System.Windows.Forms.Label();
            this.dgvStuList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGetNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalNum.Location = new System.Drawing.Point(34, 21);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(104, 16);
            this.lblTotalNum.TabIndex = 0;
            this.lblTotalNum.Text = "学生总人数：";
            // 
            // lblStuNum
            // 
            this.lblStuNum.Location = new System.Drawing.Point(158, 25);
            this.lblStuNum.Name = "lblStuNum";
            this.lblStuNum.Size = new System.Drawing.Size(67, 12);
            this.lblStuNum.TabIndex = 1;
            // 
            // dgvStuList
            // 
            this.dgvStuList.AllowUserToAddRows = false;
            this.dgvStuList.AllowUserToDeleteRows = false;
            this.dgvStuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuList.Location = new System.Drawing.Point(37, 130);
            this.dgvStuList.Name = "dgvStuList";
            this.dgvStuList.ReadOnly = true;
            this.dgvStuList.RowTemplate.Height = 23;
            this.dgvStuList.Size = new System.Drawing.Size(554, 177);
            this.dgvStuList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "符合要求的学生信息：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(314, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "符合要求的学生人数：";
            // 
            // lblGetNum
            // 
            this.lblGetNum.Location = new System.Drawing.Point(488, 75);
            this.lblGetNum.Name = "lblGetNum";
            this.lblGetNum.Size = new System.Drawing.Size(67, 12);
            this.lblGetNum.TabIndex = 6;
            // 
            // FrmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 372);
            this.Controls.Add(this.lblGetNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStuList);
            this.Controls.Add(this.lblStuNum);
            this.Controls.Add(this.lblTotalNum);
            this.Name = "FrmStudentInfo";
            this.Text = "学生信息";
            this.Load += new System.EventHandler(this.FrmStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.Label lblStuNum;
        private System.Windows.Forms.DataGridView dgvStuList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGetNum;
    }
}

