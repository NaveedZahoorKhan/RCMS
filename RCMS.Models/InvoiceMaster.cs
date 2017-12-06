using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCMS.Commons;

namespace RCMS.Models
{
    public class InvoiceMaster : ModelBase
    {
       public DateTime Dated { get; set; }
        public InvoiceType InvoiceType { get; set; } 


        // Foreign Keys
        public virtual IEnumerable<InvoiceDetail> InvoiceDetails { get; set; }

    }
}
