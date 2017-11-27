using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCMS.Models;

namespace RCMS.DAL
{
   public class RcmsContext : DbContext 
    {
        public RcmsContext(string s) : base("name=Main")
        {
        }

        public RcmsContext() : base ("name = Main")
        {
            
        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }


        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }

    public class MyContextFactory : IDbContextFactory<RcmsContext>
    {
        public RcmsContext Create()
        {
            return new RcmsContext("name=Main");
        }
    }
}
