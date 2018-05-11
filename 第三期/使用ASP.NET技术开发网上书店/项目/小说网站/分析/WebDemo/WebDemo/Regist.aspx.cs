using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Security;
using System.Collections;
using BookSet.BLL;
using BookSet.Models;

namespace WebDemo
{
    public partial class Regist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                this.seCode.Create();
            }
        }

        protected void btnSumit_Click(object sender, EventArgs e)
        {
              #region 获取所有的数据

            string username = Request.Form["username"].ToString();//账户名
            string nickName = Request.Form["userId"].ToString();//昵称
            string pas = Request.Form["password"].ToString();
            string email = Request.Form["email"].ToString();
            string pacefile = file1.PostedFile.FileName;
              if(pacefile.Equals(""))
              {
                  //为用户默认添加一张系统图片
                  pacefile = "~/images/face/1.gif";
              }
            #endregion
              #region 图片的处理以及注册的处理
              if (!this.seCode.CheckSN(this.txtCode.Text.Trim()))
              {
                this.Page.ClientScript.RegisterClientScriptBlock(this.GetType()
                    , "scriptKey", "<script>alert('验证码错误!')</script>");
                this.username.Value = username;
                this.userId.Value = nickName;
                this.email.Value = email;
             
                return;
            }
            else
            {      
            try
            {     
                FaceUrl(pacefile);
                UserManager biz = new UserManager();
                UserRole role = new UserRole();                
                User user = new User();
                #region 为user对象赋值
                user.UserId = username; //账户名
                user.Password = pas;   //账户密码
                user.Name = nickName;  //账户昵称
                user.Email = email;    //邮箱
                user.Date = DateTime.Now; //注册时间
                user.Phone = "";   //注册电话
                user.Address = "";  //注册地址
                user.HeadPortrait ="~/images/face/"+pacefile; //用户头像
                user.Integral = 5; //默认为用户添加5积分                    
              
                #endregion

            int  result=biz.Regist(user);
            string script="";
            switch(result)
            {
                case 0:
                    //注册失败
                script="<script type='text/javascript'>alert('注册失败！');</script>";
                    break;
                case 1:
                    //注册成功
                script= "<script type='text/javascript'>alert('注册成功！');</script>";
                Response.Redirect("~/Login.aspx"); 
                     break;
                case 2:
                    //用户名已存在
                script= "<script type='text/javascript'>alert('用户名已经存在！');</script>";
                   
                    break;
                }
                this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "scritpKey", script);
            }
                    catch (Exception)
                    {
                     
                        throw;
                    }
                    //注册成功后跳转到首页
            Response.Redirect("Default.aspx");
                   
            }
              #endregion              
              #region 删除图片
              //获取图片路径
              FileInfo file = new FileInfo(Server.MapPath("~/images/delect/Yang1.PNG"));
            //判断图片路径是否存在
            if(file.Exists)
           {    
            file.Attributes = FileAttributes.Normal;//设置文件属性  
            file.Delete();
           }
              #endregion
        }
          

        /// <summary>
        /// 头像
        /// </summary>
        /// <param name="url">原图路径(物理路径)</param>

        private void FaceUrl(string url)
        {
         

            //判断路径是否为空
            if (url != null)
            {
               if(file1.HasFile)
               {
                   FileInfo file = new FileInfo(url);
                   //将图片保存在项目的face文件夹里
                   file1.SaveAs(Server.MapPath("~/images/face/") + file1.FileName);
                    //将图片自动缩小成 50x50
                   string fileName = file.Name;
                   string s = "JD" + file.Name;//缩略图路径
                   string webFilePath = Server.MapPath("~/images/face/" + fileName);
                   string webFace = Server.MapPath("~/images/face/" + s);
                   try
                   {
                       MakeThumbnail(webFilePath, webFace,50,50, "Cut"); 
                   }
                   catch (Exception)
                   {
                       
                       throw;
                   }
               }
            }
            else 
            {
            
            }
            
        }


        protected void btnChack_Click(object sender, EventArgs e)
        {
            this.seCode.Create();
        }



        /// <summary>
        /// 压缩图片的方法(最兼容)
        /// </summary>
        /// <param name="originalImagePath">原图路径(物理路径)</param>
        /// <param name="thumbnailPath">缩略图路径(物理路径)</param>
        /// <param name="width">缩略图宽度</param>
        /// <param name="height">缩略图高度</param>
        /// <param name="mode">生成缩略图的方式</param>
        private static void MakeThumbnail(string originalImagePath,string thumbnailPath,int width,int height,string mode) 
        {
            System.Drawing.Image originalImage = System.Drawing.Image.FromFile(originalImagePath);
            int towidth = width;
            int toheight = height;
            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;
            switch (mode)
            {
                case "HW"://指定高宽缩放（可能变形）                
                    break;
                case "W"://指定宽，高按比例                    
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;
                case "H"://指定高，宽按比例
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case "Cut"://指定高宽裁减（不变形）                
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                default:
                    break;
            }
            //新建一个bmp图片
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight);
            //新建一个画板
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            //设置高质量插值法
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //清空画布并以透明背景色填充
            g.Clear(System.Drawing.Color.Transparent);
            //在指定位置并且按指定大小绘制原图片的指定部分
            g.DrawImage(originalImage, new System.Drawing.Rectangle(0, 0, towidth, toheight),
                new System.Drawing.Rectangle(x, y, ow, oh),
                System.Drawing.GraphicsUnit.Pixel);
            try
            {
                //以jpg格式保存缩略图
                bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (System.Exception e)
            {
                throw e;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }
        }
    
    
    }
}