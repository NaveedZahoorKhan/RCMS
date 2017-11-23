using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCMS.Models
{
   public class Addresses : ModelBase
    {
        public virtual Customers CustomerId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
    }
}
