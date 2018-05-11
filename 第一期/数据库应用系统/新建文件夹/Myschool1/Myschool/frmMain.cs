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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
      
        #region 字段
        private int index1 = -1;
        private int index2 = -1;
        private int a; 
        #endregion

        #region 属性

      
        #endregion

        #region 事件
        //窗体关闭事件
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            DialogResult result=MessageBox.Show("确定要关闭吗？","提示",MessageBoxButtons.OKCancel);

            if(result==DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                frmMain objMain = new frmMain();
                objMain.Show();
            }

        }

        //新增学员信息按钮单击事件
        private void 新增学员信息NToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        FrmInsert objStuInsert = new FrmInsert();

            //设置MDI父窗体
            objStuInsert.MdiParent = this;

            objStuInsert.Show();
        
        }
        
        //修改密码
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePwd objFrmChangePwd = new FrmChangePwd();
          objFrmChangePwd.MdiParent = this;
            objFrmChangePwd.Show();
        }

        //学员信息列表
        private void 学员信息列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStuList objFrmStuList = new FrmStuList();
            objFrmStuList.MdiParent = this;
            objFrmStuList.Show();
        }

        //退出系统方法
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要关闭吗？", "提示", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Application.Exit();
           
            }
         
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmAXMCX objaxmcx = new FrmAXMCX();

            objaxmcx.MdiParent = this;

            objaxmcx.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmANJCX objanjcx = new FrmANJCX();
            objanjcx.MdiParent = this;

            objanjcx.Show();
        }

        //帮助窗体跳转
        private void 关于系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHelp objHelp = new FrmHelp();
  
            objHelp.ShowDialog();
        }

        //时钟组件
        private void timer1_Tick(object sender, EventArgs e)
        {
            changeTime();
            if(this.timer1.Interval<500)
            {
                   this.changgeTime1();
            }
         


        }
        //窗体加载事件
        private void frmMain_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int a=r.Next(100,1000);
            this.timer1.Interval=a;

            this.label2.Hide();

            
        }

        private void 课程查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.subList();
        }

        #endregion

        #region 方法
        public void changeTime()
        {
     
            index1++;
            string []sb=new string[14];
       
            sb[0] = "天";
            sb[1] = "王";
            sb[2] = "盖";
            sb[3] = "地";
            sb[4] = "虎";
            sb[5] = "宝";
            sb[6] = "塔";
            sb[7] = "镇";
            sb[8] = "河";
            sb[9] = "妖";
            sb[10] = "我";
            sb[11] = "草";
            sb[12] = "你";
            sb[13] = "妈";
            
            if (index1 > 9)
            {
               
                this.timer1.Enabled = false;
             
            }
            if (index1 >= 5 && index1 <=9)
            {
                Random q=new Random();
                this.label1.ForeColor = Color.FromArgb(255, q.Next(0, 255), q.Next(0, 255), q.Next(0, 255));
                this.label1.Text = this.label1.Text + sb[index1] + "\n\n";

            }
   if( index1<5)
            {
                Random b = new Random();
                this.lblBQ.ForeColor = Color.FromArgb(255, b.Next(0, 255), b.Next(0, 255), b.Next(0, 255));
                this.lblBQ.Text = this.lblBQ.Text + sb[index1] + "\n\n";
            }


        }

        public void changgeTime1() 
        {
            if (this.timer1.Enabled ==false)
            {

                this.timer1.Enabled = true;
                this.label2.Show();
                index2++;
                string[] sb = new string[6];

                sb[0] = "我";
                sb[1] = "草";
                sb[2] = "你";
                sb[3] = "妈";
                sb[4] = "吴";
                sb[5] = "强";
                if (index2 > 5)
                {
                    index2 = 0;
                    this.timer1.Enabled = false;

                    this.label2.Hide();
                }
                else
                {
                    
                    this.label2.Text = this.label2.Text + sb[index2] + "\t\t";

                }
            }
        
        }

        public void subList()
        {
            FrmSubList objsublist = new FrmSubList();
            objsublist.MdiParent = this;
            objsublist.Show();
        }
        #endregion





    }
}
