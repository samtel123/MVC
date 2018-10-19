using MyFirstEmpPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstEmpPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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



        public ActionResult ShowEmployees()
        {
            ViewBag.Message = "Your Employee page.";

            Employee emp1 = new Employee();
            emp1.EmpID = 1;
            emp1.Name = "Kamal";
            emp1.Gender = 'M';
            emp1.DOB = new DateTime(1980, 11, 02);
            emp1.DOJ = new DateTime(2015, 03, 01);
            emp1.Salary = 34000;

            Employee emp2 = new Employee();
            emp2.EmpID = 2;
            emp2.Name = "Manan";
            emp2.Gender = 'M';
            emp2.DOB = new DateTime(1983, 07, 24);
            emp2.DOJ = new DateTime(2017, 04, 01);
            emp2.Salary = 30000;

            List<Employee> employees = new List<Employee>() { emp1, emp2 };

            return View(employees);
        }
    }
}