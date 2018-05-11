using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }

        #region 字段
        //图片下标
        private int index = 0;
        #endregion

        #region 属性

        #endregion

        #region 事件
        private void FrmHelp_Load(object sender, EventArgs e)
        {
            this.ChangeTime();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //更改图片
            this.ChangePicture();

            //更改时间
            this.ChangeTime();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 更改图片
        /// </summary>
        public void ChangePicture()
        { 
            //图片下标加1
            index++;
            //判断图片下标是否越界
            if (index >= this.imgList.Images.Count)
            {
                //图片下标归零
                index = 0;
            }

            //加载图片
            this.picImage.Image = this.imgList.Images[index];
        }

        /// <summary>
        /// 更改时间
        /// </summary>
        public void ChangeTime()
        { 
            //时
            int intHour = System.DateTime.Now.Hour;
            string strHour = string.Empty;

            //分
            int intMin = System.DateTime.Now.Minute;
            string strMin = string.Empty;

            //秒
            int intSec = System.DateTime.Now.Second;
            string strSec = string.Empty;

            if (intHour < 10)
            {
                strHour = "0" + intHour.ToString();
            }
            else
            {
                strHour = intHour.ToString();
            }

            if (intMin < 10)
            {
                strMin = "0" + intMin.ToString();
            }
            else
            {
                strMin = intMin.ToString();
            }

            if (intSec < 10)
            {
                strSec = "0" + intSec.ToString();
            }
            else
            {
                strSec = intSec.ToString();
            }

            //加载时间
            this.lblTime.Text = System.DateTime.Now.ToShortDateString() + " " + strHour + ":" + strMin + ":" + strSec;
        }
        #endregion

        
        
    }
}
