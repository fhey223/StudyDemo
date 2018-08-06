using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Log4Study
{
    class Program
    {
        static void Main(string[] args)
        {
            //log4net.ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            //log.Info("日志测试数据");
            for (int count = 0; count < 10; count++)
            {
                Thread writeThread = new Thread(new ParameterizedThreadStart((para) =>
                {
                    log4net.ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                    Console.WriteLine(string.Format("开启线程{0}", para));
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    for (int i = 0; i < 100000; i++)
                    {
                        log.Info(string.Format("日志测试数据,序号：{0}", i.ToString()));
                    }
                    sw.Stop();
                    Console.WriteLine(string.Format("线程{0}写入日志结束，共用时{1}毫秒", para, sw.ElapsedMilliseconds));
                }));
                writeThread.IsBackground = true;
                writeThread.Start(count);
            }
            Console.ReadKey();
        }
    }
}
