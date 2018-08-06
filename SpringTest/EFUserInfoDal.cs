using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringTest
{
    public class EFUserInfoDal : IUserInfoDal
    {
        public EFUserInfoDal()
        {

        }
        public UserInfo UserInfo { get; set; }
        public string Name { get; set; }

        public string Show()
        {
            return "我是EF Dal,属性注入：Name=" + Name;
            //Console.WriteLine("我是EF Dal,属性注入：Name=" + Name);
            //Console.WriteLine("UserInfo ,Name=" + UserInfo.Name + " Age=" + UserInfo.Age);
        }
    }
}
