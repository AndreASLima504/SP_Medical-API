using System;
using System.Collections.Generic;

#nullable disable

namespace SPMedical.Domains
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            Medicos = new HashSet<Medico>();
        }

        public int EspecialidadeId { get; set; }
        public string NomeEspecialidade { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
