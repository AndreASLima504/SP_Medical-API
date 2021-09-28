using SPMedical.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Interfaces
{
    interface IEspecialidadeRepository
    {
        List<Especialidade> ListarTodos();
        Especialidade BuscarPorId(int idEspecialidade);
        void Cadastrar(Especialidade novoEspecialidade);
        void AtualizarIdCorpo(Especialidade especialidadeAtualizada);
        void AtualizarIdUrl(int idEspecialidade, Especialidade specialidadeAtualizada);
        void Deletar(int idUsuario);
    }
}
