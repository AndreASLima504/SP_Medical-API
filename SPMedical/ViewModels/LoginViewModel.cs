using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-mail requer preenchimento")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha requer preenchimento")]
        public string Senha { get; set; }
    }
}
