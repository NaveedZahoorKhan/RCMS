using System.Collections.Generic;
using RCMS.Models;

namespace RCMS.Services.Interfaces
{
    public interface IInvoiceDetailService : IService<InvoiceDetail>
    {
        IEnumerable<InvoiceDetail> GetInvoiceDetails();
        IEnumerable<InvoiceDetail> GetInvoiceDetailsWithoutUnits();
        InvoiceDetail GetInvoiceDetail(int id);
        void CreateInvoiceDetail(InvoiceDetail invoiceDetail);
        void UpdateInvoiceDetail(InvoiceDetail invoiceDetail);
        void SaveInvoiceDetail();
        void RefreshEntity(InvoiceDetail invoiceDetail);
    }
}
