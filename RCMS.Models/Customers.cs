using System.ComponentModel.DataAnnotations;

namespace RCMS.Models
{
   public class Customer : ModelBase
    {
        
        
        public virtual User UserId { get; set; }
        
        public string Phone { get; set; }
        public string OrganizationName { get; set; }
        public string Cell { get; set; }
            


    }
}
