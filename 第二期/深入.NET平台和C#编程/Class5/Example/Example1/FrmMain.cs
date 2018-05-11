using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 字段
        //体检套餐列表
        private Dictionary<string, Health> dicHealthList = new Dictionary<string, Health>();

        //体检明细列表
        private Dictionary<string, HealthItem> dicHealItemList = new Dictionary<string, HealthItem>();
        #endregion

        #region 属性

        #endregion

        #region 事件
        //窗体加载事件
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //绑定体检套餐列表
            this.BindData1();

            //绑定体检明细列表
            this.BindData2();
        }

        //添加体检套餐按钮事件
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //添加体检套餐
            this.InsertHealth();
        }

        //体检套餐选项改变事件
        private void cmbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //改变体检套餐选项
            this.ChangeHealth();
        }

        //添加体检明细按钮
        private void btnReInsert_Click(object sender, EventArgs e)
        {
            //添加体检明细
            this.InsertHealthItem();
        }

        //删除体检明细按钮
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvInfoList.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定删除此检查项目?", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    //删除体检明细
                    this.DeleteHealthItem();
                }
            }
            else
            {
                MessageBox.Show("请选择需要删除的检查项目!");
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

            foreach (string strTemp in this.dicHealthList.Keys)
            {
                this.cmbList.Items.Add(strTemp);
            }

            //默认选项
            this.cmbList.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定体检明细列表
        /// </summary>
        public void BindData2()
        {
            //初始化体检明细列表
            this.InitialHealthItemList();

            //清空下拉菜单
            this.cmbCheckItem.Items.Clear();

            this.cmbCheckItem.Items.Add("请选择");

            foreach (string strTemp in this.dicHealItemList.Keys)
            {
                this.cmbCheckItem.Items.Add(strTemp);
            }

            //默认选项
            this.cmbCheckItem.SelectedIndex = 0;
        }

        /// <summary>
        /// 初始化体检明细列表
        /// </summary>
        public void InitialHealthItemList()
        {
            //体检名称
            string[] arrItemNameList = new string[] { "身高", "体重", "视力", "听力", "肝功", "心电图", "血压", "B超" };
            //体检明细
            string[] arrItemDetailList = new string[] { "检查身高", "检查体重", "检查视力", "检查听力", "检查肝功", "检查心电图", "检查血压", "进行B超检查" };
            //体检价格
            double[] arrItemPriceList = new double[] { 5, 5, 5, 5, 20, 100, 20, 180 };

            //加入体检套餐列表
            for (int i = 0; i < arrItemNameList.Length; i++)
            {
                HealthItem objHealthItem = new HealthItem();

                objHealthItem.ItemName = arrItemNameList[i];
                objHealthItem.ItemDetail = arrItemDetailList[i];
                objHealthItem.ItemPrice = arrItemPriceList[i];

                this.dicHealItemList.Add(objHealthItem.ItemName, objHealthItem);
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
                MessageBox.Show("套餐名称不能为空!");
                return;
            }

            //套餐是否已存在
            if (this.dicHealthList.ContainsKey(healthName))
            {
                MessageBox.Show("此体检套餐已存在!");
                return;
            }
            #endregion

            #region 新增操作
            objHealth.Name = healthName;

            //添加至体检套餐列表
            this.dicHealthList.Add(healthName, objHealth);

            //刷新套餐列表
            this.BindData1();

            //清空数据
            this.txtName.Text = string.Empty;

            MessageBox.Show("新增成功!");
            #endregion
        }

        /// <summary>
        /// 添加体检明细
        /// </summary>
        public void InsertHealthItem()
        {
            #region 设置变量
            //体检套餐名称
            string healthName = this.cmbList.Text.Trim();

            //体检明细名称
            string healthItemName = this.cmbCheckItem.Text.Trim();
            #endregion

            #region 数据验证
            //是否选择体检套餐
            if (healthName.Equals("请选择"))
            {
                MessageBox.Show("请选择体检套餐!");
                return;
            }

            //是否选择体检明细
            if (healthItemName.Equals("请选择"))
            {
                MessageBox.Show("请选择检查项目!");
                return;
            }

            //验证体检明细是否已存在
            for (int i = 0; i < this.dicHealthList[healthName].ItemList.Count; i++)
            {
                if (this.dicHealthList[healthName].ItemList[i].ItemName.Equals(healthItemName))
                {
                    MessageBox.Show("此检查项目已存在!");
                    return;
                }
            }
            #endregion

            #region 新增操作
            //添加体检项目
            this.dicHealthList[healthName].ItemList.Add(this.dicHealItemList[healthItemName]);

            this.ChangeHealth();

            MessageBox.Show("添加体检项目成功!");
            #endregion
        }

        /// <summary>
        /// 删除体检明细
        /// </summary>
        public void DeleteHealthItem()
        {
            //体检明细名称
            string healthItemName = this.dgvInfoList.SelectedRows[0].Cells[0].Value.ToString();

            //体检套餐名称
            string healthName = this.cmbList.Text.Trim();

            for (int i = 0; i < this.dicHealthList[healthName].ItemList.Count; i++)
            {
                if (this.dicHealthList[healthName].ItemList[i].ItemName.Equals(healthItemName))
                {
                    this.dicHealthList[healthName].ItemList.RemoveAt(i);

                    this.ChangeHealth();

                    MessageBox.Show("删除成功!");

                    return;
                }
            }
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

            if (!healthName.Equals("请选择"))
            {
                this.lblShowName.Text = healthName;

                for (int i = 0; i < this.dicHealthList[healthName].ItemList.Count; i++)
                {
                    //计算总价格
                    totalPrice += this.dicHealthList[healthName].ItemList[i].ItemPrice;
                }

                this.lblPrice.Text = totalPrice.ToString() + "元";

                this.dgvInfoList.DataSource = new BindingList<HealthItem>(this.dicHealthList[healthName].ItemList);
            }
            else
            {
                this.lblShowName.Text = string.Empty;

                this.lblPrice.Text = totalPrice.ToString() + "元";

                this.dgvInfoList.DataSource = new List<HealthItem>();
            }
        }
        #endregion
    }
}
