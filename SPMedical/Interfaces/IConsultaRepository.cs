using SPMedical.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Interfaces
{
    interface IConsultaRepository
    {
        List<Consulta> ListarTodos();
        Consulta BuscarPorId(int idUsuario);
        void Cadastrar(Consulta novoConsulta);
        void AtualizarIdCorpo(Consulta consultaAtualizada);
        void AtualizarIdUrl(int idConsulta, Consulta consultaAtualizada);
        void Deletar(int idUsuario);
    }
}
