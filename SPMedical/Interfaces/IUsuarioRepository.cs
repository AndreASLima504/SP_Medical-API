using SPMedical.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> ListarTodos();
        Usuario BuscarPorId(int idUsuario);
        void Cadastrar(Usuario novoUsuario);
        void AtualizarIdCorpo(Usuario usuarioAtualizada);
        void AtualizarIdUrl(int idUsuario, Usuario usuarioAtualizada);
        void Deletar(int idUsuario);

        /// <summary>
        /// Este método vai validar o usuário e logá-lo no sistema
        /// </summary>
        /// <param name="email">email do usuario</param>
        /// <param name="senha">senha do usuario</param>
        /// <returns></returns>
        Usuario Login(string email, string senha);
    }
}
