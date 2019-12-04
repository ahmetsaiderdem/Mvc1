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
    }
}

//http://ahmetsaiderdem.com/home/index
//HomeConntroller h=new HomeController();
//h.index();