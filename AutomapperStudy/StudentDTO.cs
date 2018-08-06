using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperStudy
{
    public class StudentDTO
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
        public string b
        {
            get;
            set;
        }
    }
}
