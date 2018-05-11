using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        
        #region 字段
        //体检套餐列表
        private Dictionary<string,Health> dicHealthList = new Dictionary<string,Health>();

        //体检项目列表
        private Dictionary<string, HealthItem> dicHealthItemList = new Dictionary<string, HealthItem>();
        #endregion

        #region 属性

        #endregion

        #region 事件
        //窗体加载事件
        private void frmMain_Load(object sender, EventArgs e)
        {
            //绑定体检套餐列表
            this.BindData1();

            //绑定体检项目列表
            this.BindData2();
        }

        //添加体检套餐按钮事件
        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.InsertHealth();
        }

        //体检菜单选项改变事件
        private void cmbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //改变体检套餐选项
            this.ChangeHealth();
        }

        //添加体检项目按钮事件
        private void btnItemsAdd_Click(object sender, EventArgs e)
        {
            this.InsertHealthItem();
        }

        //删除体检项目按钮事件
        private void btnClear_Click(object sender, EventArgs e)
        {
            if(this.dgvList.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定删除此检查项目吗？","删除",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    this.DeleteHealthItem();
                }
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 绑定体检套餐列表
        /// </summary>
        public void BindData1()
        { 
            //清空列表
            this.cmbList.Items.Clear();

            this.cmbList.Items.Add("请选择");

            foreach(string strTemp in this.dicHealthList.Keys)
            {
                this.cmbList.Items.Add(strTemp);
            }

            //默认选项
            this.cmbList.SelectedIndex = 0;

        }

        /// <summary>
        /// 绑定体检项目列表
        /// </summary>
        public void BindData2()
        {
            //初始化体检项目列表
            this.InitialHealthItemList();

            //清空列表
            this.cmbItemList.Items.Clear();

            this.cmbItemList.Items.Add("请选择");

            foreach (string strTemp in this.dicHealthItemList.Keys)
            {
                this.cmbItemList.Items.Add(strTemp);
            }

            //默认选项
            this.cmbItemList.SelectedIndex = 0;

            
        }

        /// <summary>
        /// 添加数据到体检项目列表
        /// </summary>
        public void InitialHealthItemList()
        { 
            //体检名称
            string[] arrItemNameList = new string[] { "身高","体重","视力","听力","肝功","B超","心电图","血压"};
            //检查描述
            string[] arrItemDataList = new string[] { "检查身高", "检查体重", "检查视力", "检查听力", "检查肝功", "进行B超检查", "检查心电图", "检查血压" };
            //体检价格
            double[] arrItemPriceList = new double[] { 5, 5, 5, 5, 20, 180, 100, 20};

            //加入体检套餐列表
            for(int i = 0; i < arrItemNameList.Length; i++)
            {
                HealthItem objHealthItem = new HealthItem();

                objHealthItem.ItemName = arrItemNameList[i];
                objHealthItem.ItemDesc = arrItemDataList[i];
                objHealthItem.ItemPrice = arrItemPriceList[i];

                this.dicHealthItemList.Add(objHealthItem.ItemName, objHealthItem);
            }
        }

        /// <summary>
        /// 添加体检套餐
        /// </summary>
        public void InsertHealth()
        {
            #region 设置变量
            //体检套餐类对象
            Health objHealth = new Health();

            //套餐名称
            string healthName = this.txtName.Text.Trim();
            #endregion

            #region 数据验证
            //非空验证
            if (string.IsNullOrEmpty(healthName))
            {
                MessageBox.Show("请输入套餐名称！");
                return;
            }

            //套餐是否已存在
            if (this.dicHealthList.ContainsKey(healthName))
            {
                MessageBox.Show("此体检套餐已存在！");
                return;
            }
            #endregion
            
            #region 添加操作
            objHealth.Name = healthName;

            //添加至体检套餐列表
            this.dicHealthList.Add(healthName, objHealth);

            //刷新套餐列表
            this.BindData1();

            //清除
            this.txtName.Text = string.Empty;
            #endregion

        }

        /// <summary>
        /// 改变体检套餐选项
        /// </summary>
        public void ChangeHealth()
        {
            #region 设置变量
            //套餐名称
            string healthName = this.cmbList.Text.Trim();

            //总价格
            double totalPrice = 0;
            #endregion

            if(!healthName.Equals("请选择"))
            {
                this.lblItemN.Text = healthName;

                //计算总价格
                foreach (HealthItem temp in this.dicHealthList[healthName].ItemDic.Values)
                {
                    totalPrice += temp.ItemPrice;
                }
 
                this.lblPriceN.Text = totalPrice.ToString() + "元";

                this.dgvList.AutoGenerateColumns = false;

                BindingSource bs = new BindingSource();
                bs.DataSource = this.dicHealthList[healthName].ItemDic.Values;
                this.dgvList.DataSource = bs;
            }
            else
            {
                this.lblItemN.Text = string.Empty;

                this.lblPriceN.Text = string.Empty;

                this.dgvList.DataSource = null;
            }
        }

        /// <summary>
        /// 添加体检项目
        /// </summary>
        public void InsertHealthItem()
        {
            #region 设置变量
            //体检套餐名称
            string healthName = this.cmbList.Text.Trim();

            //体检项目名称
            string healthItemName = this.cmbItemList.Text.Trim();
            #endregion

            #region 数据验证
            //是否选择体检套餐
            if(healthName.Equals("请选择"))
            {
                MessageBox.Show("请选择体检套餐！");
                return;
            }

            //是否选择体检项目
            if(healthItemName.Equals("请选择"))
            {
                MessageBox.Show("请选择体检项目！");
                return;
            }

            //验证体检项目是否已存在

            if (this.dicHealthList[healthName].ItemDic.ContainsKey(healthItemName))
                {
                    MessageBox.Show("体检项目已存在！");
                    return;
                }
            
            #endregion

            #region 添加操作
            //添加体检项目
            this.dicHealthList[healthName].ItemDic.Add(this.dicHealthItemList[healthItemName].ItemName, this.dicHealthItemList[healthItemName]);

            this.ChangeHealth();

            MessageBox.Show("添加体检项目成功！");
            #endregion
        }

        /// <summary>
        /// 删除体检项目
        /// </summary>
        public void DeleteHealthItem()
        { 
            //体检项目名称
            string healthItemName = this.dgvList.SelectedRows[0].Cells[0].Value.ToString();

            //体检套餐名称
            string healthName = this.cmbList.Text.Trim();


            if (this.dicHealthList[healthName].ItemDic.ContainsKey(healthItemName))
                {
                    this.dicHealthList[healthName].ItemDic.Remove(healthItemName);

                    this.ChangeHealth();

                    MessageBox.Show("删除成功！");

                    return;
                }
            
        }
        #endregion

    }
}
