namespace MySchool
{
    partial class FrmHelp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHelp));
            this.lalStuManeger = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblTechnology = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lalStuManeger
            // 
            this.lalStuManeger.AutoSize = true;
            this.lalStuManeger.BackColor = System.Drawing.Color.Transparent;
            this.lalStuManeger.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lalStuManeger.Location = new System.Drawing.Point(273, 72);
            this.lalStuManeger.Name = "lalStuManeger";
            this.lalStuManeger.Size = new System.Drawing.Size(301, 24);
            this.lalStuManeger.TabIndex = 1;
            this.lalStuManeger.Text = "学 生 信 息 管 理 系 统";
            this.lalStuManeger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMessage.Location = new System.Drawing.Point(274, 190);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(161, 16);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "版权所有：北大青鸟";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCopyright.Location = new System.Drawing.Point(274, 135);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(134, 16);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Copyright:2009";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTechnology
            // 
            this.lblTechnology.AutoSize = true;
            this.lblTechnology.BackColor = System.Drawing.Color.Transparent;
            this.lblTechnology.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTechnology.Location = new System.Drawing.Point(274, 245);
            this.lblTechnology.Name = "lblTechnology";
            this.lblTechnology.Size = new System.Drawing.Size(300, 16);
            this.lblTechnology.TabIndex = 4;
            this.lblTechnology.Text = "技术支持：StudentMis@JadeBied.com";
            this.lblTechnology.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(497, 327);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关 闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picImage
            // 
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(25, 72);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(243, 189);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 8;
            this.picImage.TabStop = false;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "girl_1.gif");
            this.imgList.Images.SetKeyName(1, "girl_2.gif");
            this.imgList.Images.SetKeyName(2, "girl_3.gif");
            this.imgList.Images.SetKeyName(3, "girl_4.gif");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(22, 284);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(246, 16);
            this.lblTime.TabIndex = 9;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTechnology);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lalStuManeger);
            this.Name = "FrmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于系统";
            this.Load += new System.EventHandler(this.FrmHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalStuManeger;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblTechnology;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
    }
}