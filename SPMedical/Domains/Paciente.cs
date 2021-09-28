using System;
using System.Collections.Generic;

#nullable disable

namespace SPMedical.Domains
{
    public partial class Paciente
    {
        public Paciente()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int PacienteId { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string TelefonePaciente { get; set; }
        public string Rgpaciente { get; set; }
        public string Cpfpaciente { get; set; }
        public string EnderecoPaciente { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
