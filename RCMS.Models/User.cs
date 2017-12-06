using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Runtime.CompilerServices;

namespace RCMS.Models
{
    public class User : ModelBase
    {
        [MaxLength(40), Required]
        public string Name { get; set; }
       
        public string Password { get; set; }
        public string Designation { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
       

        // Foreign Keys 
        public virtual Addresses Addresses { get; set; }

    }
}