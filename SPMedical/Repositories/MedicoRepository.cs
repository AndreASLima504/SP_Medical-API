using SPMedical.Contexts;
using SPMedical.Domains;
using SPMedical.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        SPMedicalContext contexto = new SPMedicalContext();
        public void AtualizarIdCorpo(Medico medicoAtualizada)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int idMedico, Medico medicoAtualizado)
        {
            Medico medicoBuscado = BuscarPorId(idMedico);
            if (medicoAtualizado.Crm != null)
            {
                medicoBuscado.Crm = medicoAtualizado.Crm;
            }
            contexto.Medicos.Update(medicoBuscado);
            contexto.SaveChanges();
        }

        public Medico BuscarPorId(int idMedico)
        {
            return contexto.Medicos.Select(u => new Medico() {
                MedicoId = u.MedicoId,
                ClinicaId = u.ClinicaId

            }

        public void Cadastrar(Medico novoMedico)
        {
            contexto.Medicos.Add(novoMedico);
            contexto.SaveChanges();
        }

        public void Deletar(int idMedico)
        {
            contexto.Medicos.Remove(BuscarPorId(idMedico));
            contexto.SaveChanges();
        }

        public List<Medico> ListarTodos()
        {
            return contexto.Medicos.ToList();
        }
    }

        public void Cadastrar(Medico novoMedico)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idMedico)
        {
            throw new NotImplementedException();
        }

        public List<Medico> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
