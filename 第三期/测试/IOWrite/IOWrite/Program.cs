using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWrite
{
    class Program
    {
        private const string FILE_NAME = "Text.txt";
        static void Main(string[] args)
        {
            //if (File.Exists(FILE_NAME))
            //{
            //    Console.WriteLine("{0} already exists", FILE_NAME);
            //    Console.ReadLine();
            //    return;
            //}
            //FileStream fs = new FileStream(FILE_NAME, FileMode.Create);

            //BinaryWriter bw = new BinaryWriter(fs);

            //for (int i = 0; i < 11; i++)
            //{
            //    bw.Write("a");
            //}
            //bw.Close();
            //fs.Close();
            using(StreamWriter sw = File.AppendText("Text.txt"))
            {
                Log("hehe",sw);
                Log("Hello World",sw);

                sw.Close();
            }
        }

        public static void Log(string logMessage, TextWriter tw)
        {
            tw.Write("\r\nLog Enter:");
            tw.WriteLine(" :{0}",logMessage);

            tw.Flush();
        }
    }
}
