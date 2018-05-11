using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Demo4.Class;

namespace Demo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 事件
        //计算按钮事件
        private void btnResult_Click(object sender, EventArgs e)
        {
            this.Calc();
        }
        #endregion

        #region 方法
        public void Calc()
        {
            #region 设置变量
            string strNum1 = this.txtDigit1.Text.Trim();

            string strNum2 = this.txtDigit2.Text.Trim();

            string strChoose = this.cmbSign.Text.Trim();

            //计算类对象
            Calc objCalc = null;
            #endregion

            #region 数据验证
            //非空
            if (string.IsNullOrEmpty(strNum1))
            {
                MessageBox.Show("请填写计算数！");
                return;
            }

            if (string.IsNullOrEmpty(strNum2))
            {
                MessageBox.Show("请填写计算数！");
                return;
            }

            if (string.IsNullOrEmpty(strChoose))
            {
                MessageBox.Show("请选择计算符合！");
                return;
            }
            #endregion

            #region 计算操作
            objCalc = new CakeFactory().GetCalc(strChoose);

            if (!objCalc.Equals(null,objCalc))
            {
                double result = objCalc.CalcFunc(double.Parse(strNum1),double.Parse(strNum2));
                this.lblResult.Text = result.ToString();
            }
            #endregion
        }
        #endregion
    }
}
