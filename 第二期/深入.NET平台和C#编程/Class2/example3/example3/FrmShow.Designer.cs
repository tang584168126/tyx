namespace example3
{
    partial class FrmShow
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
            this.lvSelect = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvSelect
            // 
            this.lvSelect.FullRowSelect = true;
            this.lvSelect.Location = new System.Drawing.Point(13, 13);
            this.lvSelect.Name = "lvSelect";
            this.lvSelect.Size = new System.Drawing.Size(517, 237);
            this.lvSelect.TabIndex = 0;
            this.lvSelect.UseCompatibleStateImageBehavior = false;
            // 
            // FrmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 262);
            this.Controls.Add(this.lvSelect);
            this.Name = "FrmShow";
            this.Text = "查看评分";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSelect;
    }
}

