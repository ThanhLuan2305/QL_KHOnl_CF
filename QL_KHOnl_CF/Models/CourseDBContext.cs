using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace QL_KHOnl_CF.Models
{
    public class CourseDBContext : DbContext
    {
        public CourseDBContext() : base("MyconnectionString") { }
        public DbSet<TYPE_COURSE> TYPE_COURSES { get; set; }
        public DbSet<COURSE> COURSES { get; set; }
        public DbSet<USER_COURSE> USER_COURSES { get; set; }
        public DbSet<CART_OF_USER> CART_OF_USERS { get; set; }
        public DbSet<ORDER_COURSE> ORDER_COURSES { get; set; }
        public DbSet<TEACHER> TEACHERS { get; set; }
        public DbSet<ASSIGNMENTS> ASSIGNMENTS { get; set; }
        public DbSet<QUIZZES> QUIZZES { get; set; }
        public DbSet<GRADES> GRADES { get; set; }
        
    }
}