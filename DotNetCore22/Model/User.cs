using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore22.Model
{
    public class RegisterViewModel
    {
       
     
        [Required]
        public string email { get; set; }
       
        [Required]
        public string  password { get; set; }
        [Required]
        public string Confirmpassword { get; set; }

    }
}
