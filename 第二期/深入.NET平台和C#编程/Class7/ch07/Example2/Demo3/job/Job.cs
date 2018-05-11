using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.job
{
    /// <summary>
    /// 父类：工作类
    /// </summary>
    public class Job
    {
        #region 字段
        //工作类型
        private string strType;

        //工作名称
        private string strName;

        //工作描述
        private string strDesc;
        #endregion

        #region 属性
        //工作类型
        public string StrType
        {
            get { return strType; }
            set { strType = value; }
        }

        //工作名称
        public string StrName
        {
            get { return strName; }
            set { strName = value; }
        }

        //工作描述
        public string StrDesc
        {
            get { return strDesc; }
            set { strDesc = value; }
        }
        #endregion

        #region 方法
        public void job()
        {
        
        }

        public virtual void Execute()
        { 
        
        }
        #endregion
    }
}
