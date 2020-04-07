using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCurdDemo.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public string Mail { get; set; }
        public DateTime DOJ { get; set; }
    }
}