using System;
using System.Collections.Generic;

#nullable disable

namespace SPMedical.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Medicos = new HashSet<Medico>();
        }

        public int ClinicaId { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string EnderecoClinica { get; set; }
        public string RazaoSocial { get; set; }
        public TimeSpan? HorarioFechamento { get; set; }
        public TimeSpan? HorarioAbertura { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
