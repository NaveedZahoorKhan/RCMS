using System;
using RCMS.DAL.Infrastructure.Interfaces;

namespace RCMS.DAL.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        RcmsContext _dbContext;

        public RcmsContext Init() => _dbContext ?? (_dbContext = new RcmsContext(GetConnection()));

        protected override void DisposeCore()
        {
            _dbContext?.Dispose();
        }

        private string GetConnection()

        {
            string s = $@"{Environment.MachineName}\SQLEXPRESS";
            string cnString = $"Data Source={s};Initial Catalog=RCMSDevDb;Integrated Security=True;";
           
            // cn = new SqlConnection(cnString);
            return cnString;
        }

      
    }
}
