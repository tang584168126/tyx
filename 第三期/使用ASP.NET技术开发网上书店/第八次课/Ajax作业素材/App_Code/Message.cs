using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
///Message 的摘要说明
/// </summary>
public class MessageInfo
{
    private int id;         // 留言id

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private String message;  // 留言内容

    public String Message
    {
        get { return message; }
        set { message = value; }
    }
    private String author;   // 作者

    public String Author
    {
      get { return author; }
      set { author = value; }
    }

    private String postTime; // 发布时间

    public String PostTime
    {
      get { return postTime; }
      set { postTime = value; }
    }

    private string email;//邮箱
    public String Email
    {
        get { return email; }
        set { email = value; }
    }

    private string webSite;//网站
    public String WebSite
    {
        get { return webSite; }
        set { webSite = value; }
    }

    private string userIp;//用户IP
    public String UserIp
    {
        get { return userIp; }
        set { userIp = value; }
    }

    private string faceUrl;//表情
    public String FaceUrl
    {
        get { return faceUrl; }
        set { faceUrl = value; }
    }

    private string picUrl;//头像
    public String PicUrl
    {
        get { return picUrl; }
        set { picUrl = value; }
    }

    private bool isHide;//匿名
    public bool IsHide
    {
        get { return isHide; }
        set { isHide = value; }
    }
	
	private int rowNo;//楼号
    public int RowNo
    {
        get { return rowNo; }
        set { rowNo = value; }
    }
}
