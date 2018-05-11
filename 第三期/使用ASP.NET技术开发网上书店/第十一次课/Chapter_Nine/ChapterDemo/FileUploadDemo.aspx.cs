using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChapterDemo
{
    public partial class FileUploadDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(this.fuImg.HasFile)   //判断要上传的文件是否存在
            {
                string filename = this.fuImg.FileName;
                string strPath = this.Server.MapPath("Images/" + filename);
                this.fuImg.SaveAs(strPath);
            }
        }
    }
}