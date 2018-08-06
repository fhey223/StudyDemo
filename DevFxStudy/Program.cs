using Devfx.IService;
using HTB.DevFx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFxStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            var svr = ObjectService.GetObject<IPeration>();
            var a = svr.Add(3, 5);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
