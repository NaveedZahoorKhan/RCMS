using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCMS.Models
{
    public class ExpenseType : ModelBase
    {
        [Required]
        public string Type { get; set; }
        public string Detail { get; set; }

    }
}
