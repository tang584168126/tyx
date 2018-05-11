using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example4
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
        //加载下拉菜单事件
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.BindList();
        }
        //计算按钮事件
        private void btnResult_Click(object sender, EventArgs e)
        {
            this.Count();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 绑定下拉菜单
        /// </summary>
        public void BindList()
        {
            string[] sum = new string[] { "+", "-", "*", "/" };
            this.cmbSign.SelectedItem = 0;

            for (int i = 0; i < sum.Length; i++ )
            {
                this.cmbSign.Items.Add(sum[i]);
            }
        }

        /// <summary>
        /// 计算
        /// </summary>
        public void Count()
        { 
            #region 设置变量
            string num = string.Empty;
            string Number1 = this.txtDigit1.Text.Trim();

            string Number2 = this.txtDigit2.Text.Trim();
            #endregion

            #region 数据验证
            if (string.IsNullOrEmpty(Number1))
            {
                MessageBox.Show("请输入数字！");
                return;
            }

            if (string.IsNullOrEmpty(Number2))
            {
                MessageBox.Show("请输入数字！");
                return;
            }
            #endregion

            #region 计算操作
            Operation opr = new Operation();

            switch(this.cmbSign.SelectedItem.ToString().Trim())
            {
                case "+":
                    opr = new OperationAdd();
                    break;

                case "-":
                    opr = new OperationSub();
                    break;

                case "*":
                    opr = new OperationMul();
                    break;

                case "/":
                    opr = new OperationDiv();
                    break;
            }
            opr.NumberA1 = double.Parse(Number1);
            opr.NumberB1 = double.Parse(Number2);

            this.lblResult.Text = opr.GetResult(ref num).ToString();

            if (!string.IsNullOrEmpty(num))
            {
                MessageBox.Show("除数不能为0！");
            }
        }

            #endregion
        #endregion

    }
}
