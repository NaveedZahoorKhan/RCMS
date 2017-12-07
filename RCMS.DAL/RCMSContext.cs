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
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<InvoiceMaster> InvoiceMasters { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<Receiveables> Receiveables { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProductUnit> ProductUnits { get; set; }
        public DbSet<User> Users { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
         
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
