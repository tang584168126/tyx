namespace Demo2
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
            this.gbGraph = new System.Windows.Forms.GroupBox();
            this.rbtRectangle = new System.Windows.Forms.RadioButton();
            this.rbtRound = new System.Windows.Forms.RadioButton();
            this.imgPanel = new System.Windows.Forms.Panel();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.rbtBlue = new System.Windows.Forms.RadioButton();
            this.rbtYellow = new System.Windows.Forms.RadioButton();
            this.rbtRed = new System.Windows.Forms.RadioButton();
            this.btnDraw = new System.Windows.Forms.Button();
            this.gbGraph.SuspendLayout();
            this.gbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGraph
            // 
            this.gbGraph.Controls.Add(this.rbtRectangle);
            this.gbGraph.Controls.Add(this.rbtRound);
            this.gbGraph.Location = new System.Drawing.Point(357, 13);
            this.gbGraph.Name = "gbGraph";
            this.gbGraph.Size = new System.Drawing.Size(215, 159);
            this.gbGraph.TabIndex = 6;
            this.gbGraph.TabStop = false;
            this.gbGraph.Text = "图形";
            // 
            // rbtRectangle
            // 
            this.rbtRectangle.AutoSize = true;
            this.rbtRectangle.Location = new System.Drawing.Point(7, 61);
            this.rbtRectangle.Name = "rbtRectangle";
            this.rbtRectangle.Size = new System.Drawing.Size(47, 16);
            this.rbtRectangle.TabIndex = 1;
            this.rbtRectangle.Text = "矩形";
            this.rbtRectangle.UseVisualStyleBackColor = true;
            // 
            // rbtRound
            // 
            this.rbtRound.AutoSize = true;
            this.rbtRound.Checked = true;
            this.rbtRound.Location = new System.Drawing.Point(7, 21);
            this.rbtRound.Name = "rbtRound";
            this.rbtRound.Size = new System.Drawing.Size(47, 16);
            this.rbtRound.TabIndex = 0;
            this.rbtRound.TabStop = true;
            this.rbtRound.Text = "圆形";
            this.rbtRound.UseVisualStyleBackColor = true;
            // 
            // imgPanel
            // 
            this.imgPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgPanel.Location = new System.Drawing.Point(13, 13);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(320, 387);
            this.imgPanel.TabIndex = 5;
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.rbtBlue);
            this.gbColor.Controls.Add(this.rbtYellow);
            this.gbColor.Controls.Add(this.rbtRed);
            this.gbColor.Location = new System.Drawing.Point(357, 205);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(215, 159);
            this.gbColor.TabIndex = 7;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "颜色";
            // 
            // rbtBlue
            // 
            this.rbtBlue.AutoSize = true;
            this.rbtBlue.Location = new System.Drawing.Point(6, 118);
            this.rbtBlue.Name = "rbtBlue";
            this.rbtBlue.Size = new System.Drawing.Size(47, 16);
            this.rbtBlue.TabIndex = 3;
            this.rbtBlue.Text = "蓝色";
            this.rbtBlue.UseVisualStyleBackColor = true;
            // 
            // rbtYellow
            // 
            this.rbtYellow.AutoSize = true;
            this.rbtYellow.Location = new System.Drawing.Point(7, 76);
            this.rbtYellow.Name = "rbtYellow";
            this.rbtYellow.Size = new System.Drawing.Size(47, 16);
            this.rbtYellow.TabIndex = 2;
            this.rbtYellow.Text = "黄色";
            this.rbtYellow.UseVisualStyleBackColor = true;
            // 
            // rbtRed
            // 
            this.rbtRed.AutoSize = true;
            this.rbtRed.Checked = true;
            this.rbtRed.Location = new System.Drawing.Point(7, 34);
            this.rbtRed.Name = "rbtRed";
            this.rbtRed.Size = new System.Drawing.Size(47, 16);
            this.rbtRed.TabIndex = 1;
            this.rbtRed.TabStop = true;
            this.rbtRed.Text = "红色";
            this.rbtRed.UseVisualStyleBackColor = true;
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDraw.Location = new System.Drawing.Point(497, 370);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 26);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "绘  制";
            this.btnDraw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.gbGraph);
            this.Controls.Add(this.imgPanel);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.Text = "绘图板";
            this.gbGraph.ResumeLayout(false);
            this.gbGraph.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGraph;
        private System.Windows.Forms.RadioButton rbtRectangle;
        private System.Windows.Forms.RadioButton rbtRound;
        private System.Windows.Forms.Panel imgPanel;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.RadioButton rbtBlue;
        private System.Windows.Forms.RadioButton rbtYellow;
        private System.Windows.Forms.RadioButton rbtRed;
        private System.Windows.Forms.Button btnDraw;
    }
}

