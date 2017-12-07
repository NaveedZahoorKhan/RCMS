using System;

namespace RCMS.DAL.Infrastructure.Interfaces
{
    public interface IDbFactory: IDisposable
    {
        RcmsContext Init();
    }
}
