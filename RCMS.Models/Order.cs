using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCMS.Models
{
    public class Order : ModelBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime OrderDate { get; set; }
            


        //ForeignKey
        public virtual IEnumerable<Item> Items { get; set; } 
        
        public virtual Customers CustomerId { get; set; }
        
    }
}
