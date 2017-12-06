using System.ComponentModel.DataAnnotations;

namespace RCMS.Models
{
    public class ProductUnit : ModelBase
    {
        [Required]
       public string Unit { get; set; }
        public string UnitFullName { get; set; }
    }
}