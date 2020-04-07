using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCurdDemo.Models;

namespace WebApiCurdDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        DataContext db = new DataContext();

        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return db.Employee.ToList();

        }

        [HttpGet]
        public Employee GetEmployee(int id)
        {
            return db.Employee.Find(id);
        }

        [HttpPost]
        public void AddEmployee(Employee employee)
        {

            db.Employee.Add(employee);
            db.SaveChanges();
        }
        [HttpPut]
        public void EditUser(int EmployeeId, Employee employee)
        {
            if (EmployeeId == employee.EmployeeId)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        [HttpDelete]
        public void DeleteEmployee(int EmployeeId)
        {
            Employee employee = db.Employee.Find(EmployeeId);
            if (employee!= null)
            {
                db.Employee.Remove(employee);
                db.SaveChanges();
            }

        }
    }
}
