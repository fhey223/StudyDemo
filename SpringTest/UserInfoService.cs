using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringTest
{
    public class UserInfoService
    {
        public string Name { get; set; }
        public Person Person { get; set; }
        public string ShowMsg()
        {
            return "Hello World:" + Name + "年龄是:" + Person.Age;
        }
    }
}
