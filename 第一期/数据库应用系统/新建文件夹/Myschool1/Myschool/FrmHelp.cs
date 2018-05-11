using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myschool
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }

        #region 字段
        //图片下标
        private int index;
        private int index1= -1;
     #endregion

        #region 属性
        #endregion

        #region 事件
        //关闭按钮事件
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //时钟组件运行
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ChangePicture();

            this.ChangeTime();

            this.ChangeColor();
        }
        #endregion

        #region 方法
        public void ChangePicture()
        { 
            //图片下标加1
            index++;

            //判断图片下标是否越界
        if(index>=this.imgList.Images.Count)
        {
            //图片下标归零
            index = 0;        
        }

            //加载图片
        this.picImage.Image = this.imgList.Images[index];

        }

        //系统时间显示
        public void ChangeTime()
        {
            //lblTime.Text= System.DateTime.Now.ToString();

            //时
            int inHour = System.DateTime.Now.Hour;
            string strHour = string.Empty;

            //分
            int intMin = System.DateTime.Now.Minute;
            string strMin = string.Empty;

            //秒
            int intSec = System.DateTime.Now.Second;
            string strSec = string.Empty;

            if (inHour < 10)
            {
                strHour = "0" + strHour;

            }
            else
            {
                strHour = inHour.ToString();
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

            this.lblTime.Text = strHour + ":" + strMin + ":" + strSec;

        }

        public void ChangeColor()
        {
           
           string[] sb = new string[9];
           index1++;
           sb[0] = "胡";

           sb[1] = "逸";

           sb[2] = "丶";

           sb[3] = "吴";

           sb[4] = "强";

           sb[5] = "丶";

           sb[6] = "黄";

           sb[7] = "世";

           sb[8] = "林";
            if(index1>8)
            {
                index1 = 0;
                this.label1.Text = string.Empty;
            }
           
           this.label1.Text = this.label1.Text+sb[index1];

        }
        #endregion

    }
}
