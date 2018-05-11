using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//为图片添加数字水印要用到IO和画图相关的类
using System.IO;
using System.Drawing;

namespace HttpHandlerDemo
{
    /// <summary>
    /// BookCover 的摘要说明
    /// </summary>
    public class BookCover : IHttpHandler
    {
        //获取封面图片存放位置
        private const string COVERADDR = "~/Images/BookCovers/";
        //默认图片位置
        private const string DEFAULTLIMAGE_URL = "~/Images/default.jpg";
        //水印图片路径
        private const string WATERMARK_URL = "~/Images/WaterMark.jpg";
        public void ProcessRequest(HttpContext context)
        {
            //1.根据请求来获取isbn
            //2.拼接书籍封面图片存放路径 + isbn + .jpg 获取图片的路径
            string path = context.Request.MapPath(COVERADDR + context.Request.QueryString["isbn"] + ".jpg");

            //返回的图片
            Image cover;

            //3.判定图片是否存在，如果不存在，返回默认封面图片
            if (File.Exists(path))
            {
                //4.封面图片存在，为其添加水印
                cover = Image.FromFile(path);
                //加载水印图片
                Image waterMark = Image.FromFile(context.Request.MapPath(WATERMARK_URL));

                //创建画布，将封面图片放到画布上
                Graphics g = Graphics.FromImage(cover);
                //将水印放到封面图片上
                g.DrawImage(waterMark, new Rectangle(cover.Width - waterMark.Width, cover.Height - waterMark.Height,waterMark.Width,waterMark.Height),
                    0,0,waterMark.Width,waterMark.Height,System.Drawing.GraphicsUnit.Pixel);
                //释放画布和水印图片
                g.Dispose();
                waterMark.Dispose();
            }
            else
            {
                cover = Image.FromFile(context.Request.MapPath(DEFAULTLIMAGE_URL));
            }
            //5.将添加了数字水印的图片响应回客户端
            //指明响应的数据类型
            context.Response.ContentType = "image/jpg";
            cover.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);

            //释放封面图片资源
            cover.Dispose();
            //结束响应
            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}