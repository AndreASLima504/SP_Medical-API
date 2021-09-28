using SPMedical.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> ListarTodos();
        TipoUsuario BuscarPorId(int idTipoUsuario);
        void Cadastrar(TipoUsuario novoTipoUsuario);
        void AtualizarIdCorpo(TipoUsuario tipoUsuarioAtualizada);
        void AtualizarIdUrl(int idTipoUsuario, TipoUsuario tipoUsuarioAtualizada);
        void Deletar(int idUsuario);
    }
}
