using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiCurdDemo.Models;
using Newtonsoft.Json;



namespace WebApiCurdDemo.Controllers
{
    [EnableCors(origins: "http://localhost:56893/api/", headers: "*", methods: "*")]
    public class DepartmentController : ApiController
    {
        DataContext db = new DataContext();

        [HttpGet]
        public int Getdeptid(int id)
        {
            return id;
        }

        [HttpGet]
        public IEnumerable<Department> GetDepartments()
        {
            return db.Department.ToList();
        }

        [HttpGet]
        public Department GetDepartment(int id)
        {
            return db.Department.Find(id);
        }


    }
}
