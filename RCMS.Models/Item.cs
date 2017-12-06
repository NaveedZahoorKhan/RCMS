using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCMS.Models
{
    public class Item : ModelBase
    {
        [MaxLength(40)]
        public string Name { get; set; }
        public string Code { get; set; }
    
       
        public string Discription { get; set; }
        
        public double Price { get; set; }
        public double DiscoutPercent { get; set; }
      
        // Foreign Keys
       public virtual ProductUnit ProductUnit { get; set; }
       public virtual Category Category { get; set; }
    }
}
