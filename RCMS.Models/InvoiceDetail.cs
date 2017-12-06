using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCMS.Models
{
   public class InvoiceDetail : ModelBase
    {
       public DateTime Dated { get; set; }
        public double Amount { get; set; }
        public string Remarks { get; set; }


        // Foreign Key
        public virtual InvoiceMaster InvoiceMaster { get; set; }
        public virtual IEnumerable<Item> Items { get; set; }


    }
}
