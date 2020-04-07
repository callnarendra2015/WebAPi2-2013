using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiCurdDemo.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DefaultConnection")
	        {

	        }
        public DbSet<User> User{get;set;}
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }
        
    }
}