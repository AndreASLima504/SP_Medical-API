using SPMedical.Contexts;
using SPMedical.Domains;
using SPMedical.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        SPMedicalContext contexto = new SPMedicalContext();
        public void AtualizarIdCorpo(Usuario usuarioAtualizada)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int idUsuario, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = BuscarPorId(idUsuario);
            //verifica se o novo nome do Usuario não é nulo
            if(usuarioAtualizado.Nome != null)
            {
                //se não for nulo (inválido), atualiza
                usuarioBuscado.Nome = usuarioAtualizado.Nome;
            }

            if(usuarioAtualizado.Senha != null)
            {
                usuarioBuscado.Senha = usuarioAtualizado.Senha;
            }

            contexto.Usuarios.Update(usuarioBuscado);
            contexto.SaveChanges();
        }

        public Usuario BuscarPorId(int idUsuario)
        {
            return contexto.Usuarios.FirstOrDefault(U => U.UsuarioId == idUsuario);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            contexto.Usuarios.Add(novoUsuario);
            contexto.SaveChanges();
        }

        public void Deletar(int idUsuario)
        {
            Usuario usuarioBuscado = BuscarPorId(idUsuario);
            contexto.Usuarios.Remove(usuarioBuscado);
            contexto.SaveChanges();
        }

        public List<Usuario> ListarTodos()
        {
            //retorna lista com todos os usuários
            return contexto.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            return contexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
