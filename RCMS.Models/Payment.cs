using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCMS.Models
{
    public class Payment : ModelBase
    {

        public float Amount { get; set; }
        public DateTime Dated { get; set; }
        public string Remarks { get; set; }
    

        //  Foreign Keys
        public virtual Vendor Vendor { get; set; }
        
    }
}
