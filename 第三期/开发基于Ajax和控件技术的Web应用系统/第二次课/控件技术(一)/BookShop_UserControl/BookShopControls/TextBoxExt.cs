using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

[assembly:WebResource("BookShopControls.Scripts.Validate.js","text/javascript")]
namespace BookShopControls
{
    [ToolboxData("<{0}:TextBoxExt runat=server></{0}:TextBoxExt>")]
    public class TextBoxExt : TextBox
    {
        public ValidateType ValType { get; set; }
        protected override void OnPreRender(EventArgs e)
        {
            //执行父控件的动作
            base.OnPreRender(e);    
            //将脚本注册到页面中
            Page.ClientScript.RegisterClientScriptResource(this.GetType(), "BookShopControls.Scripts.Validate.js");
        }

        protected override void Render(HtmlTextWriter writer)
        {
            base.Render(writer);
            if (this.ValType == ValidateType.NoZeroInteger)
            {
                writer.Write("元");
            }
            else if (this.ValType == ValidateType.BigChar)
            {
                writer.Write("!");
            }
        }

        protected override void AddAttributesToRender(HtmlTextWriter writer)
        {
            base.AddAttributesToRender(writer);
            if (this.ValType == ValidateType.NoZeroInteger || this.ValType == ValidateType.BigChar)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Onchange, "checkNoZeroInteger(this,'" + this.ValType + "')");
            }
        }

        public enum ValidateType
        {
            NoZeroInteger = 1,      //非零正整数
            BigChar = 2             //大写字母
        }
    }
}
