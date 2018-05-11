using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Demo3.job;

namespace Demo3
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

        #endregion

        #region 方法
        /// <summary>
        /// 初始化某员工工作列表
        /// </summary>
        public void init()
        {
            List<Job> objList = new List<Job>();

            objList.Add(new CodeJob("编码","编码","实现购物车模块"));
        }
        #endregion
    }
}
