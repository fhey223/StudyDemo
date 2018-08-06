using Ivony.Html;
using Ivony.Html.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumonyStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //抓取小说
            FileStream fs = null;
            if (File.Exists("D\\c.txt"))
            {
                fs = new FileStream("D:\\c.txt", FileMode.Append);
            }
            else
            {
                fs = new FileStream("D:\\c.txt", FileMode.Create);
            }


            var sw = new StreamWriter(fs, Encoding.UTF8);

            var baseUrl = "http://www.42xs.com/read/0/404/";
            var nextUrl = "171271.html";
            var url = "";
            var txt = "";
            var title = "";
            while (nextUrl != "")
            {
                try
                {
                    url = baseUrl + nextUrl;
                    var doc = new JumonyParser().LoadDocument(url);
                    var titleDom = doc.FindFirst("#center > div.title > h1");
                    title = titleDom.InnerText();

                    var dom = doc.FindFirst("#content");
                    txt = dom.InnerText();

                    var domNext = doc.FindFirst("#container > div:nth-child(3) > div > div.jump > a:nth-child(6)");
                    nextUrl = domNext.Attribute("href").Value();
                }
                catch
                {
                    Console.WriteLine("{0}没有成功", url);
                    nextUrl = "";
                }

                Console.WriteLine(title);
                sw.WriteLine("");
                sw.WriteLine(title);
                sw.WriteLine("");
                sw.WriteLine(txt);
            }
            Console.Write("The End. Press any key to exit...");
            Console.ReadKey();

            sw.Close();
            fs.Close();
        }
    }
}
