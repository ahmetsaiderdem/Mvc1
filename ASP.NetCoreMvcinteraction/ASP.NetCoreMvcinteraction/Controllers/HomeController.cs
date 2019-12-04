using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NetCoreMvcinteraction.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            return "Hello from first application";
        }
        public ViewResult Index2()
        {
            return View();
        }
    }
}

//http://ahmetsaiderdem.com/home/index
//HomeConntroller h=new HomeController();
//h.index();