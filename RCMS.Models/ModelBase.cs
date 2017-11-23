using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCMS.Models
{
    public class ModelBase
    {
        
        public int Id { get; set; } 
        [Required]
        public int CreatedBy { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime DateModified { get; set; }
    }
}
