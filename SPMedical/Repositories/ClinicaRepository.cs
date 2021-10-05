using SPMedical.Contexts;
using SPMedical.Domains;
using SPMedical.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        SPMedicalContext contexto = new SPMedicalContext();
        public void AtualizarIdCorpo(Clinica clinicaAtualizada)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int idClinica, Clinica clinicaAtualizada)
        {
            Clinica clinicaBuscada = BuscarPorId(idClinica);

            if(clinicaAtualizada != null)
            {
                clinicaBuscada.NomeFantasia = clinicaAtualizada.NomeFantasia;
            }
            if (clinicaAtualizada != null)
            {
                clinicaBuscada.Cnpj = clinicaAtualizada.Cnpj;
            }
            if (clinicaAtualizada != null)
            {
                clinicaBuscada.EnderecoClinica = clinicaAtualizada.EnderecoClinica;
            }
            if (clinicaAtualizada != null)
            {
                clinicaBuscada.RazaoSocial = clinicaAtualizada.RazaoSocial;
            }
            if (clinicaAtualizada != null)
            {
                clinicaBuscada.HorarioAbertura = clinicaAtualizada.HorarioAbertura;
            }
            if (clinicaAtualizada != null)
            {
                clinicaBuscada.HorarioFechamento = clinicaAtualizada.HorarioFechamento;
            }
            contexto.Clinicas.Update(clinicaBuscada);
            contexto.SaveChanges();
        }

        public Clinica BuscarPorId(int idClinica)
        {
            return contexto.Clinicas.FirstOrDefault(U => U.ClinicaId == idClinica);
        }

        public void Cadastrar(Clinica novoClinica)
        {
            contexto.Clinicas.Add(novoClinica);
            contexto.SaveChanges();
        }

        public void Deletar(int idClinica)
        {
            Clinica clinicaBuscada = BuscarPorId(idClinica);
            contexto.Clinicas.Remove(clinicaBuscada);
            contexto.SaveChanges();
        }

        public List<Clinica> ListarTodos()
        {
            return contexto.Clinicas.ToList();
        }
    }
}
