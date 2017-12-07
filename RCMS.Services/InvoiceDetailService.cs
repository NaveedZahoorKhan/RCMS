using System.Collections.Generic;
using RCMS.DAL.Infrastructure.Interfaces;
using RCMS.Models;
using RCMS.Services.Interfaces;

namespace RCMS.Services
{
    public class InvoiceDetailService : ServiceBase<InvoiceDetail>, IInvoiceDetailService
    {
        public InvoiceDetailService(IUnitOfWork unitOfWork, IRepository<InvoiceDetail> repository) : base(unitOfWork, repository)
        {
        }

        public IEnumerable<InvoiceDetail> GetInvoiceDetails()
        {
            return UnitOfWork.InvoiceDetailRepository.GetAll();
        }

        public IEnumerable<InvoiceDetail> GetInvoiceDetailsWithoutUnits()
        {
            throw new System.NotImplementedException();
        }

        public InvoiceDetail GetInvoiceDetail(int id)
        {
            return UnitOfWork.InvoiceDetailRepository.GetById(id);
        }

        public void CreateInvoiceDetail(InvoiceDetail InvoiceDetail)
        {
            UnitOfWork.InvoiceDetailRepository.Add(InvoiceDetail);
        }

        public void UpdateInvoiceDetail(InvoiceDetail InvoiceDetail)
        {
            UnitOfWork.InvoiceDetailRepository.Update(InvoiceDetail);
        }

        public void SaveInvoiceDetail()
        {
            UnitOfWork.Commit();
        }
    }
}
