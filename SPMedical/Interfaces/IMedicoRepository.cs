using SPMedical.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Interfaces
{
    interface IMedicoRepository
    {
        List<Medico> ListarTodos();
        Medico BuscarPorId(int idPaciente);
        void Cadastrar(Medico novoMedico);
        void AtualizarIdCorpo(Medico medicoAtualizada);
        void AtualizarIdUrl(int idMedico, Medico medicoAtualizada);
        void Deletar(int idUsuario);
    }
}
