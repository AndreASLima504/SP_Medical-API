using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SPMedical.Domains
{
    public partial class Medico
    {
        public Medico()
        {
            Consulta = new HashSet<Consulta>();
        }

        [Required(ErrorMessage = "Um médico válido é necessário para fazer esta operação")]
        public int MedicoId { get; set; }
        public int? EspecialidadeId { get; set; }
        public int? UsuarioId { get; set; }
        public string Crm { get; set; }
        public int ClinicaId { get; set; }

        public virtual Clinica Clinica { get; set; }
        public virtual Especialidade Especialidade { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
