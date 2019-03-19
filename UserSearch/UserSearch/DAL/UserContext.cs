using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UserSearch.Models;

namespace UserSearch.DAL
{
    public class UserContext : DbContext
    {
        public UserContext() : base("UserContext")
        {

        }
    }

    public DbSet<Person> People { get; set; }
}