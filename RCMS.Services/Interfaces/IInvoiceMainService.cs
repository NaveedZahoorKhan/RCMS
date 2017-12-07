using System.Collections.Generic;
using RCMS.Models;

namespace RCMS.Services.Interfaces
{
    public interface IInvoiceMasterService : IService<InvoiceMaster>
    {
        IEnumerable<InvoiceMaster> GetInvoiceMasters();
        IEnumerable<InvoiceMaster> GetInvoiceMastersWithoutUnits();
        InvoiceMaster GetInvoiceMaster(int id);
        void CreateInvoiceMaster(InvoiceMaster invoiceMaster);
        void UpdateInvoiceMaster(InvoiceMaster invoiceMaster);
        void SaveInvoiceMaster();
        void RefreshEntity(InvoiceMaster invoiceMaster);
    }
}
