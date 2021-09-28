using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SPMedical.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Medicos = new HashSet<Medico>();
            Pacientes = new HashSet<Paciente>();
        }

        public int UsuarioId { get; set; }
        public int? TipoUsuarioId { get; set; }
        public string Nome { get; set; }
        [Required (ErrorMessage = "O campo de e-mail deve ser preenchido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo de senha deve ser preenchido!")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "A senha deve ter de 8 a 20 caracteres")]
        public string Senha { get; set; }

        public virtual TipoUsuario TipoUsuario { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
