using PaginationTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace PaginationTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? page)
        {
            List<Student> sList = new List<Student>()
            {
                new Student(){Name = "reza1", EnrollNo = 1},
                new Student(){Name = "reza2", EnrollNo = 2},
                new Student(){Name = "reza3", EnrollNo = 3},
                new Student(){Name = "reza4", EnrollNo = 4},
                new Student(){Name = "reza5", EnrollNo = 5},
                new Student(){Name = "reza6", EnrollNo = 6},
                new Student(){Name = "reza7", EnrollNo = 7},
                new Student(){Name = "reza8", EnrollNo = 8},
                new Student(){Name = "reza9", EnrollNo = 9},
                new Student(){Name = "reza10", EnrollNo = 10},
                new Student(){Name = "reza11", EnrollNo = 11},
                new Student(){Name = "reza12", EnrollNo = 12},
                new Student(){Name = "reza13", EnrollNo = 13},
                new Student(){Name = "reza14", EnrollNo = 14},
            };

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return PartialView("Partial/_StudentList", sList.ToPagedList(pageNumber, pageSize));
            //return View(sList.ToPagedList(1,1));
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