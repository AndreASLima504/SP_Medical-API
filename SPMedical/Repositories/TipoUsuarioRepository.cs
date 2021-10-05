using SPMedical.Contexts;
using SPMedical.Domains;
using SPMedical.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        SPMedicalContext contexto = new SPMedicalContext();
        public void AtualizarIdCorpo(TipoUsuario tipoUsuarioAtualizada)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int idTipoUsuario, TipoUsuario tipoUsuarioAtualizada)
        {
            TipoUsuario tipoUsuarioBuscado = BuscarPorId(idTipoUsuario);
            if(tipoUsuarioAtualizada.NomeTipo != null)
            {
                tipoUsuarioBuscado.NomeTipo = tipoUsuarioAtualizada.NomeTipo;
            }
            contexto.TipoUsuarios.Update(tipoUsuarioBuscado);
        }

        public TipoUsuario BuscarPorId(int idTipoUsuario)
        {
            return contexto.TipoUsuarios.FirstOrDefault(t => t.TipoUsuarioId == idTipoUsuario);
        }

        public void Cadastrar(TipoUsuario novoTipoUsuario)
        {
            contexto.TipoUsuarios.Add(novoTipoUsuario);
            contexto.SaveChanges();
        }

        public void Deletar(int idUsuario)
        {
            contexto.TipoUsuarios.Remove(BuscarPorId(idUsuario));
            contexto.SaveChanges();
        }

        public List<TipoUsuario> ListarTodos()
        {
            return contexto.TipoUsuarios.ToList();
        }
    }
}
