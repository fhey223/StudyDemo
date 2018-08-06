using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperStudy
{
    class Program : Profile
    {

        static void Main(string[] args)
        {
            Student s = new Student();
            s.StuID = 123456;
            s.Name = "哈哈哈哈";
            s.Age = 20;
            s.a = null;
            //1
            Mapper.Initialize(x => x.CreateMap<Student, StudentDTO>());
            //Null值替换
            //继承映射属性
            //Mapper.Initialize(x => x.CreateMap<Student, StudentDTO>().ForMember(o => o.b, m => m.MapFrom(n => n.a)).ForMember(o => o.b, m => m.NullSubstitute("屌丝")));
            var dto1 = Mapper.Map<StudentDTO>(s);

            //2
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentDTO>());
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentDTO>().ForMember(o=>o.b,m=>m.MapFrom(n=>n.a)));
            var mapper = config.CreateMapper();
            var dto2 = mapper.Map<StudentDTO>(s);

            //3
            var dto3 = Mapper.Instance.Map<Student, StudentDTO>(s);

            Console.WriteLine(dto2.Age);
            Console.WriteLine(dto2.Name);
            Console.WriteLine(dto2.StuID);
            Console.Read();
        }
    }
}
