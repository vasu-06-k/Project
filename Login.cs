using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRBAL1
{
    public class Loginadmin
    {
        [Required]
        [Display(Name = "Enter User Name", Order = 1)]
        [MinLength(5, ErrorMessage = "Name must be min 5 chars long")]
        public string username { get; set; }
        [Required]
        [Display(Name = "Enter Password", Order = 2)]
        public string password { get; set; }
    }
}
