using BookShop.BLL;
using BookShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;

namespace BookShop
{
    public partial class JsonTest : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            List<User> users = new UserManager().GetUsersByRoleId(3);
            DateTime date = DateTime.Now;
            if (users != null)
            {
                DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<User>));
                string jsonTest = "";
                using (MemoryStream stream = new MemoryStream())
                {
                    json.WriteObject(stream, users);

                    jsonTest = Encoding.UTF8.GetString(stream.ToArray());
                }
                string str = jsonTest;
                Response.Write(str);
                //string str1 = new JavaScriptSerializer().Serialize(date.ToShortDateString() + date.ToShortTimeString());

                //Context.Response.Write(str1);
            }
        }
    }
}