using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MySchool
{
    public partial class FrmStuUpdate : Form
    {
        public FrmStuUpdate()
        {
            InitializeComponent();
        }
        #region 字段
        //学号
        private string stuNO;

        private string sql = @"Data Source = TANG; Initial Catalog = MySchool182; User ID = sa; Pwd = 123";

        private SqlConnection objSqlConn;

        private SqlCommand objSqlComm;
        #endregion

        #region 属性
        //学号
        public string StuNO
        {
            get { return stuNO; }
            set { stuNO = value; }
        }
        #endregion



        #region 事件
       

        //窗体加载事件
        private void FrmStuUpdate_Load(object sender, EventArgs e)
        {
            this.BindData();
            this.GetDefaultValue();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 加载下拉菜单选项方法
        /// </summary>
        public void BindData()
        {
            objSqlConn = new SqlConnection(sql);

            string sqlText = "select GradeID,GradeName from Grade";

            objSqlComm = new SqlCommand(sqlText, objSqlConn);

            try
            {
                objSqlConn.Open();

                SqlDataReader dataReader = objSqlComm.ExecuteReader();

                this.cmbGradeID.Items.Clear();      //清空下拉菜单选项

                this.cmbGradeID.Items.Add("请选择");   //添加请选择选项

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        //循环添加下拉菜单选项
                        this.cmbGradeID.Items.Add(dataReader["GradeName"].ToString());
                    }
                }

                this.cmbGradeID.SelectedIndex = 0; //选中下拉菜单默认选项

                dataReader.Close();
                objSqlConn.Close();
            }
            catch
            {
                MessageBox.Show("数据库连接失败，请联系管理员！");
            }
            finally
            {
                objSqlConn.Close();
            }
        }

        /// <summary>
        /// 获取窗体默认值
        /// </summary>
        public void GetDefaultValue()
        {
            objSqlConn = new SqlConnection(sql);

            string sqlText = "select StudentNo,studentName,Sex,GradeID,Phone,Address,BornDate,Email from Student";

            objSqlComm = new SqlCommand(sqlText, objSqlConn);

            try
            {
                objSqlConn.Open();

                SqlDataReader dataReader = objSqlComm.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        this.txtStuNo.Text = this.StuNO;

                        this.txtName.Text = dataReader["StudentName"].ToString();
                        this.txtPhone.Text = dataReader["Phone"].ToString();
                        this.txtAdress.Text = dataReader["Address"].ToString();
                        this.txtEmail.Text = dataReader["Email"].ToString();

                        if (dataReader["Sex"].ToString().Equals("False"))
                        {
                            this.rbtMale.Checked = true;
                        }
                        this.cmbGradeID.SelectedIndex = int.Parse(dataReader["GradeID"].ToString());
                        this.dtpBornDate.Value = Convert.ToDateTime(dataReader["BornDate"].ToString());
                    }
                }
                objSqlConn.Close();
            }
            catch
            {
                MessageBox.Show("数据库连接失败，请联系管理员！");
            }
            finally
            {
                objSqlConn.Close();
            }
        }


        #endregion

       
    }
}

