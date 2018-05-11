using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Demo1.Class;

namespace Demo1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 事件
        //计算按钮事件
        private void btnCalc_Click(object sender, EventArgs e)
        {
            this.Calc();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 计算方法
        /// </summary>
        public void Calc()
        {
            #region 设置变量
            //计算数一
            string strNum1 = this.txtNum1.Text.Trim();

            //计算数二
            string strNum2 = this.txtNum2.Text.Trim();

            //计算符号
            string strChoose = this.cmbChoose.Text.Trim();

            //计算类对象
            Calc objCalc = null;
            #endregion

            #region 数据验证
            //非空验证
            if (string.IsNullOrEmpty(strNum1))
            {
                MessageBox.Show("请填写计算数!");
                return;
            }
            if (string.IsNullOrEmpty(strNum2))
            {
                MessageBox.Show("请填写计算数!");
                return;
            }
            if (string.IsNullOrEmpty(strChoose))
            {
                MessageBox.Show("请选择计算符号!");
                return;
            }
            #endregion

            #region 计算操作
            //获取计算类对象
            objCalc = new CalcFactory().GetCalc(strChoose);

            if (!object.Equals(null, objCalc))
            {
                double result = objCalc.CalcFunc(double.Parse(strNum1), double.Parse(strNum2));

                this.lblResult.Text = "计算结果:" + result.ToString();
            }
            else
            {
                MessageBox.Show("出现未知错误,请联系管理员!");
            }
            #endregion
        }
        #endregion
    }
}
