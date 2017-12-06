using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCMS.Models
{
    public class Expense : ModelBase
    {
        public DateTime Dated { get; set; }
        public int Amount { get; set; }
        public int Remarks { get; set; }
        

        public virtual ExpenseType ExpenseType { get; set; }
    }
}
