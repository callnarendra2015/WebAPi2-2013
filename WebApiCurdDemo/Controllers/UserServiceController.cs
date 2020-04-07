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
    public class UserServiceController : ApiController
    {
        DataContext db = new DataContext();

        [HttpGet]
        public int Getid(int id)
        {
            return id;
        }

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return db.User.ToList();
        }

        [HttpGet]
        public User GetUser(int id)
        {
            return db.User.Find(id);
        }

        [HttpPost]
        public void AddUser(User user)
        {
            if(user!=null)
            { 
            db.User.Add(user);
            db.SaveChanges();
            }

        }

        [HttpPut]
        public void EditUser(int UserId, User user)
        {
            if (UserId == user.UserId)
            {
                db.Entry(user).State=EntityState.Modified;
                db.SaveChanges();
            }
        }

        [HttpDelete]
        public void DeleteUser(int UserId)
        {
            User user = db.User.Find(UserId);
            if (user!=null)
            {
                db.User.Remove(user);
                db.SaveChanges();
            }

        }

    }
}
