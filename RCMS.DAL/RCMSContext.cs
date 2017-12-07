using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using RCMS.DAL.Infrastructure;
using RCMS.DAL.Migrations;
using RCMS.DAL.Repositories;
using RCMS.Models;

namespace RCMS.DAL
{
    /// <inheritdoc />
    public class RcmsContext : DbContext
    {
        public RcmsContext() : base("name=Main")
        {

        }
        public virtual void Commit()
        {
            try
            {
                ManageStamps();

                base.SaveChanges();

            }
            catch (DbEntityValidationException e)
            {
                //                var newException = new FormattedDbEntityValidationException(e);
                StringBuilder sb = new StringBuilder();

                foreach (var failure in e.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb.ToString(), e
                ); // Add the original exception as the innerException
            }
        }

        #region DbSets

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<InvoiceMaster> InvoiceMasters { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<ProductUnit> ProductUnits { get; set; }
        public virtual DbSet<Receiveables> Receiveableses { get; set; }
        public virtual DbSet<Payment> Payments  { get; set; }
        public virtual DbSet<ExpenseType> ExpenseTypes { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public RcmsContext(string cn) : base(cn)
        {

            var andMigrateDatabaseToLatestVersion = new CheckAndMigrateDatabaseToLatestVersion<RcmsContext, Configuration>();
            andMigrateDatabaseToLatestVersion.InitializeDatabase(this);
            //            DbMigrationsConfiguration configuration = new DbMigrationsConfiguration { AutomaticMigrationsEnabled = true };
            //            configuration.TargetDatabase = new DbConnectionInfo(cn);
            //            configuration.CodeGenerator = new CSharpMigrationCodeGenerator();
            //            configuration.AutomaticMigrationDataLossAllowed = true;
            //            configuration.ContextType = new VmsContext().GetType();
            //            DbMigrator dbMigrator = new DbMigrator(configuration);
            //            dbMigrator.GetLocalMigrations();
            //            dbMigrator.Update();


            //           

        }
        #endregion
        private void ManageStamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is ModelBase && (x.State == EntityState.Added || x.State == EntityState.Modified));

            /*var currentUsername = HttpContext.Current != null && HttpContext.Current.User != null
                ? HttpContext.Current.User.Identity.Name
                : "Anonymous";

            var currentUserId = HttpContext.Current != null && HttpContext.Current.User != null
                ? HttpContext.Current.User.Identity.GetUserId()
                : null;*/

            /*var currentUserId;
            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((ModelBase)entity.Entity).CreationDate = DateTime.Now;
                    if (currentUserId != null)
                        ((ModelBase)entity.Entity).CreatedBy = Convert.ToInt32(currentUserId);
                }
                else
                {
                    ((ModelBase)entity.Entity).ModificationDate = DateTime.Now;
                    if (currentUserId != null)
                        ((ModelBase)entity.Entity).ModifiedBy = Convert.ToInt32(currentUserId);
                }
            }*/
        }

    }
}
