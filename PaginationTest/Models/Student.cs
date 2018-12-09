using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginationTest.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int EnrollNo { get; set; }
        public int PageCount { get; set; }
        public int PageNumber { get; set; }
    }
}