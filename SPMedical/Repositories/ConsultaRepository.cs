using SPMedical.Contexts;
using SPMedical.Domains;
using SPMedical.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        SPMedicalContext contexto = new SPMedicalContext();
        public void AtualizarIdCorpo(Consulta consultaAtualizada)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int idConsulta, Consulta consultaAtualizada)
        {
            Consulta consultaBuscada = BuscarPorId(idConsulta);
            if(consultaAtualizada.DataConsulta != null)
            {
                consultaBuscada.DataConsulta = consultaAtualizada.DataConsulta;
            }
            contexto.Consultas.Update(consultaBuscada);
            contexto.SaveChanges();
        }

        public Consulta BuscarPorId(int idConsulta)
        {
            return contexto.Consultas.FirstOrDefault(c => c.ConsultaId == idConsulta);
        }

        public void Cadastrar(Consulta novoConsulta)
        {
            if(novoConsulta.Medico != null){
                contexto.Consultas.Add(novoConsulta);
                contexto.SaveChanges();
        }

        public void Deletar(int idUsuario)
        {
            contexto.Consultas.Remove(BuscarPorId(idUsuario));
            contexto.SaveChanges();
        }

        public List<Consulta> ListarTodos()
        {
            return contexto.Consultas.ToList();
        }
    }
}
