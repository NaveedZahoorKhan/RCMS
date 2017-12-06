using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCMS.Models
{
    public class Vendor : ModelBase
    {
        public string VendorCode { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
       public string Cell { get; set; }
        public virtual User UserId { get; set; }
    }
}
