using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.job
{
    /// <summary>
    /// 子类：编码类
    /// </summary>
    public class CodeJob:Job
    {
        #region 字段
        //用例个数
        private int codeNum;

        //Bug个数
        private int codeBugName;

        //工作日
        private int codeDayNum;
        #endregion

        #region 属性
        //用例个数
        public int CodeNum
        {
            get { return codeNum; }
            set { codeNum = value; }
        }

        //Bug个数
        public int CodeBugName
        {
            get { return codeBugName; }
            set { codeBugName = value; }
        }

        //工作日
        public int CodeDayNum
        {
            get { return codeDayNum; }
            set { codeDayNum = value; }
        }
        #endregion

        #region 方法
        public override void Execute()
        {
            FrmCodeJob objCodeJob = new FrmCodeJob();

            objCodeJob.ShowDialog();
        }
        #endregion
    }
}
