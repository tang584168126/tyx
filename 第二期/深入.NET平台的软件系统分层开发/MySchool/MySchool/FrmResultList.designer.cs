namespace MySchool
{
    partial class FrmResultList
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtStudentResult = new System.Windows.Forms.TextBox();
            this.lblStudentResult = new System.Windows.Forms.Label();
            this.dgvResultList = new System.Windows.Forms.DataGridView();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.lblSubName = new System.Windows.Forms.Label();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.lblStuName = new System.Windows.Forms.Label();
            this.gbCondition = new System.Windows.Forms.GroupBox();
            this.StudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultList)).BeginInit();
            this.gbCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(507, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "清  空";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(386, 127);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查  询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtStudentResult
            // 
            this.txtStudentResult.Location = new System.Drawing.Point(130, 81);
            this.txtStudentResult.MaxLength = 50;
            this.txtStudentResult.Name = "txtStudentResult";
            this.txtStudentResult.Size = new System.Drawing.Size(451, 23);
            this.txtStudentResult.TabIndex = 12;
            // 
            // lblStudentResult
            // 
            this.lblStudentResult.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentResult.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStudentResult.Location = new System.Drawing.Point(12, 81);
            this.lblStudentResult.Name = "lblStudentResult";
            this.lblStudentResult.Size = new System.Drawing.Size(90, 23);
            this.lblStudentResult.TabIndex = 11;
            this.lblStudentResult.Text = "成  绩";
            this.lblStudentResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvResultList
            // 
            this.dgvResultList.AllowUserToAddRows = false;
            this.dgvResultList.AllowUserToDeleteRows = false;
            this.dgvResultList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNo,
            this.StudentName,
            this.SubjectNo,
            this.SubjectName,
            this.StudentResult,
            this.ExamDate});
            this.dgvResultList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvResultList.Location = new System.Drawing.Point(0, 176);
            this.dgvResultList.Name = "dgvResultList";
            this.dgvResultList.ReadOnly = true;
            this.dgvResultList.RowTemplate.Height = 23;
            this.dgvResultList.Size = new System.Drawing.Size(604, 236);
            this.dgvResultList.TabIndex = 4;
            // 
            // txtSubName
            // 
            this.txtSubName.Location = new System.Drawing.Point(390, 22);
            this.txtSubName.MaxLength = 20;
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(191, 23);
            this.txtSubName.TabIndex = 10;
            // 
            // lblSubName
            // 
            this.lblSubName.BackColor = System.Drawing.Color.Transparent;
            this.lblSubName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSubName.Location = new System.Drawing.Point(294, 22);
            this.lblSubName.Name = "lblSubName";
            this.lblSubName.Size = new System.Drawing.Size(90, 23);
            this.lblSubName.TabIndex = 6;
            this.lblSubName.Text = "科目名称";
            this.lblSubName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(130, 22);
            this.txtStuName.MaxLength = 20;
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(144, 23);
            this.txtStuName.TabIndex = 5;
            // 
            // lblStuName
            // 
            this.lblStuName.BackColor = System.Drawing.Color.Transparent;
            this.lblStuName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuName.Location = new System.Drawing.Point(12, 22);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(90, 23);
            this.lblStuName.TabIndex = 2;
            this.lblStuName.Text = "学员姓名";
            this.lblStuName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbCondition
            // 
            this.gbCondition.Controls.Add(this.btnClear);
            this.gbCondition.Controls.Add(this.btnQuery);
            this.gbCondition.Controls.Add(this.txtStudentResult);
            this.gbCondition.Controls.Add(this.lblStudentResult);
            this.gbCondition.Controls.Add(this.txtSubName);
            this.gbCondition.Controls.Add(this.lblSubName);
            this.gbCondition.Controls.Add(this.txtStuName);
            this.gbCondition.Controls.Add(this.lblStuName);
            this.gbCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCondition.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbCondition.Location = new System.Drawing.Point(0, 0);
            this.gbCondition.Name = "gbCondition";
            this.gbCondition.Size = new System.Drawing.Size(604, 156);
            this.gbCondition.TabIndex = 3;
            this.gbCondition.TabStop = false;
            this.gbCondition.Text = "查询条件";
            // 
            // StudentNo
            // 
            this.StudentNo.DataPropertyName = "StudentNo";
            this.StudentNo.HeaderText = "学号";
            this.StudentNo.Name = "StudentNo";
            this.StudentNo.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StuName";
            this.StudentName.HeaderText = "学员姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // SubjectNo
            // 
            this.SubjectNo.DataPropertyName = "SubjectNo";
            this.SubjectNo.HeaderText = "课程编号";
            this.SubjectNo.Name = "SubjectNo";
            this.SubjectNo.ReadOnly = true;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubName";
            this.SubjectName.HeaderText = "科目名称";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // StudentResult
            // 
            this.StudentResult.DataPropertyName = "StudentResult";
            this.StudentResult.HeaderText = "学员成绩";
            this.StudentResult.Name = "StudentResult";
            this.StudentResult.ReadOnly = true;
            // 
            // ExamDate
            // 
            this.ExamDate.DataPropertyName = "ExamDate";
            this.ExamDate.HeaderText = "考试时间";
            this.ExamDate.Name = "ExamDate";
            this.ExamDate.ReadOnly = true;
            // 
            // FrmResultList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 412);
            this.Controls.Add(this.dgvResultList);
            this.Controls.Add(this.gbCondition);
            this.Name = "FrmResultList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩列表";
            this.Load += new System.EventHandler(this.FrmResultList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultList)).EndInit();
            this.gbCondition.ResumeLayout(false);
            this.gbCondition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtStudentResult;
        private System.Windows.Forms.Label lblStudentResult;
        private System.Windows.Forms.DataGridView dgvResultList;
        private System.Windows.Forms.TextBox txtSubName;
        private System.Windows.Forms.Label lblSubName;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.GroupBox gbCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamDate;
    }
}