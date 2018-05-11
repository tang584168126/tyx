using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work4
{
    /// <summary>
    /// 打印机类
    /// </summary>
    public class Printer
    {
        #region 字段
        //墨盒
        private InkBox inkBox;

        //纸张
        private Paper paper;
        #endregion

        #region 属性
        //墨盒
        public InkBox InkBox
        {
            get { return inkBox; }
            set { inkBox = value; }
        }

        //纸张
        public Paper Paper
        {
            get { return paper; }
            set { paper = value; }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 设置打印机墨盒
        /// </summary>
        /// <param name="inkBox">墨盒</param>
        public void SetInkBox(InkBox inkBox)
        {
            this.inkBox = inkBox;
        }

        /// <summary>
        /// 设置纸张大小
        /// </summary>
        /// <param name="paper">纸张</param>
        public void SetPaper(Paper paper)
        {
            this.paper = paper;
        }

        /// <summary>
        /// 输出打印机信息
        /// </summary>
        public void Print()
        {
            Console.WriteLine("使用" + inkBox.GetColour() + "墨盒在" + paper.GetSize() + "纸张上打印...");
        }
        #endregion
    }
}
