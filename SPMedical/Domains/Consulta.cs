using System;
using System.Collections.Generic;

#nullable disable

namespace SPMedical.Domains
{
    public partial class Consulta
    {
        public int ConsultaId { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public DateTime? DataConsulta { get; set; }
        public string DescConsulta { get; set; }

        public virtual Medico Medico { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
