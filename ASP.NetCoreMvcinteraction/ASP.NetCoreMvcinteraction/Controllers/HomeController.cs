using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NetCoreMvcinteraction.Entities;
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

        public ViewResult Index3()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {Id=1,FirstName="Ahmet",LastName="Erdem",CityId=6},
                new Employee {Id=1,FirstName="zeynep",LastName="Erdem",CityId=6},
                new Employee {Id=1,FirstName="ayşe",LastName="Erdem",CityId=34}
            };
            List<string> cities = new List<string> { "İstanbul", "Ankara" };

            var model = EmployeeListViewModel
            {
                Employees = employees,
                Cities = cities
            };
            return View(employees);
        }
    }
}

//http://ahmetsaiderdem.com/home/index
//HomeConntroller h=new HomeController();
//h.index();