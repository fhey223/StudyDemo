using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperStudy
{
    public class Student
    {
        private long stuID;
        public long StuID
        {
            get { return stuID; }
            set { stuID = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string a
        {
            get;
            set;
        }
    }
}
