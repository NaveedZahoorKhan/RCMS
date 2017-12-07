using System.Collections.Generic;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;
using RCMS.Services.Interfaces;

namespace RCMS.Services
{
    public class InvoiceMasterService : ServiceBase<InvoiceMaster>, IInvoiceMasterService
    {
        public InvoiceMasterService(IUnitOfWork unitOfWork, IRepository<InvoiceMaster> repository) : base(unitOfWork, repository)
        {
        }

        public IEnumerable<InvoiceMaster> GetInvoiceMasters()
        {
            return UnitOfWork.InvoiceMasterRepository.GetAll();
        }

        public IEnumerable<InvoiceMaster> GetInvoiceMastersWithoutUnits()
        {
            throw new System.NotImplementedException();
        }

        public InvoiceMaster GetInvoiceMaster(int id)
        {
            return UnitOfWork.InvoiceMasterRepository.GetById(id);
        }

        public void CreateInvoiceMaster(InvoiceMaster invoiceMaster)
        {
            UnitOfWork.InvoiceMasterRepository.Add(invoiceMaster);
        }

        public void UpdateInvoiceMaster(InvoiceMaster invoiceMaster)
        {
                UnitOfWork.InvoiceMasterRepository.Update(invoiceMaster);
        }

        public void SaveInvoiceMaster()
        {
            UnitOfWork.Commit();
        }
    }
}
