using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.job
{
    /// <summary>
    /// 子类：测试类
    /// </summary>
    public class TestJob:Job
    {
        #region 字段
        //用例个数
        private int testNum;

        //Bug个数
        private int testBugNum;

        //工作日
        private int testDayNum;
        #endregion

        #region 属性
        //用例个数
        public int TestNum
        {
            get { return testNum; }
            set { testNum = value; }
        }

        //Bug个数
        public int TestBugNum
        {
            get { return testBugNum; }
            set { testBugNum = value; }
        }

        //工作日
        public int TestDayNum
        {
            get { return testDayNum; }
            set { testDayNum = value; }
        }
        #endregion

        #region 方法
        public void TestJob()
        { 
        
        }

        public override void Execute()
        {
            FrmTestJob objTestJob = new FrmTestJob();

            objTestJob.ShowDialog();
        }
        #endregion
    }
 
}
