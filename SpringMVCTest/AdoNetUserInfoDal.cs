using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTest
{
    public class AdoNetUserInfoDal : IUserInfoDal
    {
        public AdoNetUserInfoDal(string name, UserInfo userInfo)
        {
            Name = name;
            UserInfo = userInfo;
        }
        public UserInfo UserInfo { get; set; }
        public string Name { get; set; }

        public string Show()
        {
            return "我是 AdoNet Dal, 属性注入：Name = " + Name;
            //Console.WriteLine("我是 AdoNet Dal ,属性注入：Name=" + Name);
            //Console.WriteLine("UserInfo ,Name=" + UserInfo.Name + " Age=" + UserInfo.Age);
        }
    }
}
