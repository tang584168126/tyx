using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace MySchoolDemo
{
    public partial class FrmStudentInfo : Form
    {
        private readonly string CONNSTR = ConfigurationManager.ConnectionStrings["MySchool"].ConnectionString;

        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        private void FrmStudentInfo_Load(object sender, EventArgs e)
        {
            this.lblStuNum.Text = GetStudentCount().ToString();

            int count;
            //this.dgvStuList.DataSource = GetStudentInfo();
            //this.dgvStuList.DataSource = GetStudentByOutput(out count);
            this.dgvStuList.DataSource = GetStudentInfoByReturn(out count).Tables[0];
            this.lblGetNum.Text = count.ToString();
        }

        /// <summary>
        /// 获取学生总人数
        /// </summary>
        /// <returns></returns>
        public int GetStudentCount()
        {
            #region 未使用SqlHelper的代码
            //SqlConnection objConn = new SqlConnection(CONNSTR);

            //SqlCommand objComm = new SqlCommand("usp_GetStudentCount", objConn);
            //objComm.CommandType = CommandType.StoredProcedure;

            //int totalNum = 0;
            //try
            //{
            //    objConn.Open();

            //    totalNum = (int)objComm.ExecuteScalar();

            //    return totalNum;
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    objConn.Close();
            //}
            //return 0;
            #endregion

            #region 调用SqlHelper中的代码
            return (int)SqlHelper.ExecuteScalar(CONNSTR, "usp_GetStudentCount");
            #endregion
        }

        /// <summary>
        /// 符合要求的学生信息
        /// </summary>
        /// <returns></returns>
        public List<Student> GetStudentInfo()
        {
            #region 未使用SqlHelper的代码
            //SqlConnection objConn = new SqlConnection(CONNSTR);

            //SqlCommand objComm = new SqlCommand("usp_GetStudentInfo", objConn);
            //objComm.CommandType = CommandType.StoredProcedure;
            //objComm.Parameters.Add("@sex",SqlDbType.Char).Value = '1';

            //List<Student> stuList = new List<Student>();
            //try
            //{
            //    objConn.Open();
            //    SqlDataReader dr = objComm.ExecuteReader();

            //    if (dr.HasRows)
            //    {
            //        while (dr.Read())
            //        {
            //            Student stu = new Student();
            //            stu.StudentNo = (int)dr["StudentNo"];
            //            stu.StudentName = dr["StudentName"].ToString();
            //            stu.Sex = Convert.ToChar(dr["Sex"]);
            //            stu.Address = dr["Address"].ToString();

            //            stuList.Add(stu);
            //        }
            //    }
            //    dr.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{

            //    objConn.Close();
            //}
            //return stuList;
            #endregion

            #region 使用SqlHelper的代码
            SqlParameter[] paras = {new SqlParameter("@sex", '1')};
            List<Student> stuList = new List<Student>();
            
            try
            {
                SqlDataReader dr = SqlHelper.ExecuteReader(CONNSTR, "usp_GetStudentInfo", paras);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Student stu = new Student();
                        stu.StudentNo = (int)dr["StudentNo"];
                        stu.StudentName = dr["StudentName"].ToString();
                        stu.Sex = Convert.ToChar(dr["Sex"]);
                        stu.Address = dr["Address"].ToString();

                        stuList.Add(stu);
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return stuList;
            #endregion
        }

        /// <summary>
        /// 获取符合要求的学生信息及人数
        /// </summary>
        /// <returns></returns>
        public List<Student> GetStudentByOutput(out int count)
        {
            count = 0;
            SqlConnection objConn = new SqlConnection(CONNSTR);

            SqlCommand objComm = new SqlCommand("usp_GetStudentInfoByOutput", objConn);
            objComm.CommandType = CommandType.StoredProcedure;
            objComm.Parameters.Add("@sex", SqlDbType.Char).Value = '1';
            objComm.Parameters.Add("@count", SqlDbType.Int);
            objComm.Parameters["@count"].Direction = ParameterDirection.Output;

            List<Student> stuList = new List<Student>();
            try
            {
                objConn.Open();
                SqlDataReader dr = objComm.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Student stu = new Student();
                        stu.StudentNo = (int)dr["StudentNo"];
                        stu.StudentName = dr["StudentName"].ToString();
                        stu.Sex = Convert.ToChar(dr["Sex"]);
                        stu.Address = dr["Address"].ToString();

                        stuList.Add(stu);
                    }
                }
                dr.Close();
                count = Convert.ToInt32(objComm.Parameters["@count"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                objConn.Close();
            }
            return stuList;
        }

        /// <summary>
        /// 获取符合要求的学生信息及人数    DataSet
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public DataSet GetStudentInfoByReturn(out int count)
        {
            count = 0;
            SqlConnection objConn = new SqlConnection(CONNSTR);

            SqlCommand objComm = new SqlCommand("usp_GetStudentInfoByReturn", objConn);
            objComm.CommandType = CommandType.StoredProcedure;
            SqlParameter[] paras = new SqlParameter[] {
                new SqlParameter("@sex",'1'),
                new SqlParameter("@returnValue",SqlDbType.Int)
            };
            objComm.Parameters.AddRange(paras);
            objComm.Parameters["@returnValue"].Direction = ParameterDirection.ReturnValue;

            SqlDataAdapter da = new SqlDataAdapter(objComm);

            DataSet ds = new DataSet();
            da.Fill(ds,"StudentInfo");

            count = Convert.ToInt32(objComm.Parameters["@returnValue"].Value);

            return ds;
        }
    }
}
