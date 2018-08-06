using Spring.Context;
using Spring.Context.Support;
using Spring.Objects.Factory.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTest.Controllers
{
    public class HomeController : Controller
    {
        [Autowired]
        public IUserInfoDal UserInfoDal { get; set; }
        public string UserName { get; set; }

        public ActionResult Index()
        {
            //IOC
            IApplicationContext ctx = ContextRegistry.GetContext();
            IUserInfoDal efDal = ctx.GetObject("UserInfoDal") as IUserInfoDal;
            var a = efDal.Show();

            IUserInfoDal adoDal = ctx.GetObject("UserInfoDal2") as IUserInfoDal;
            adoDal.Show();

            //DI
            var a1 = UserInfoDal;
            var a2 = UserName;
            
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}