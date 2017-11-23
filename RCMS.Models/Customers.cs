using System.ComponentModel.DataAnnotations;

namespace RCMS.Models
{
   public class Customers : ModelBase
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }


    }
}
