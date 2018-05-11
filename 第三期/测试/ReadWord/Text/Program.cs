using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using word = Microsoft.Office.Interop.Word;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            GetWordContent("E:/测试.doc");

            Console.ReadLine();
        }
        public static string GetWordContent(string path)
        {
            try
            {
                word.Application app = new Microsoft.Office.Interop.Word.Application();
                Type wordType = app.GetType();
                word.Document doc = null;
                object unknow = Type.Missing;
                app.Visible = false;
 
                object file = path;
                doc = app.Documents.Open(ref file,
                ref unknow, ref unknow, ref unknow, ref unknow,
                ref unknow, ref unknow, ref unknow, ref unknow,
                ref unknow, ref unknow, ref unknow, ref unknow,
                ref unknow, ref unknow, ref unknow);
                int count = doc.Paragraphs.Count;
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i <= count; i++)
                {
 
                    sb.Append(doc.Paragraphs[i].Range.Text.Trim());
                }
 
                doc.Close(ref unknow, ref unknow, ref unknow);
                wordType.InvokeMember("Quit", System.Reflection.BindingFlags.InvokeMethod, null, app, null);
                doc = null;
                app = null;
                //垃圾回收
                GC.Collect();
                GC.WaitForPendingFinalizers();
 
                string temp=sb.ToString();
                if (temp.Length > 200)
                return temp.Substring(0, 200);
                else
                return temp;
                }
                catch
                {
                return "";
                }
            }
    }
}
