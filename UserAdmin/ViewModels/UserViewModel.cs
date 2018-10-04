using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserAdmin.ViewModels
{
    public class UserViewModel
    {        
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Mail { get; set; }
        [Required]
        [MinLength(5)]
        public string Users { get; set; }
        [Required]
        [RegularExpressionAttribute("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{10,}$")]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string Password { get; set; }
        [Required]        
        public bool Status { get; set; }
        [Required]
        public string Sex { get; set; }
    }
}
