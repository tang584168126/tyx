using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsManagerSystem.Model
{
    public class NewsInfoEntity
    {
        private int id;           //编号

        public int Id
        {
            get { return id; }
        }
        private string name;       //主题

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string content;    //内容    

        public string Content
        {
            get { return content; }
            set { content = value; }
        }
    }
}
