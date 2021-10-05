using SPMedical.Contexts;
using SPMedical.Domains;
using SPMedical.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        SPMedicalContext contexto = new SPMedicalContext();
        public void AtualizarIdCorpo(Paciente pacienteAtualizada)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int idPaciente, Paciente pacienteAtualizado)
        {
            Paciente pacienteBuscado = BuscarPorId(idPaciente);
            if(pacienteAtualizado.Cpfpaciente != null)
            {
                pacienteBuscado.Cpfpaciente = pacienteAtualizado.Cpfpaciente;
            }
            if (pacienteAtualizado.DataNascimento != null)
            {
                pacienteBuscado.DataNascimento = pacienteAtualizado.DataNascimento;
            }
            if (pacienteAtualizado.EnderecoPaciente != null)
            {
                pacienteBuscado.EnderecoPaciente = pacienteAtualizado.EnderecoPaciente;
            }
            if (pacienteAtualizado.TelefonePaciente != null)
            {
                pacienteBuscado.TelefonePaciente = pacienteAtualizado.TelefonePaciente;
            }
            if (pacienteAtualizado.Rgpaciente != null)
            {
                pacienteBuscado.Rgpaciente = pacienteAtualizado.Rgpaciente;
            }
            contexto.Pacientes.Update(pacienteBuscado);
            contexto.SaveChanges();
        }

        public Paciente BuscarPorId(int idPaciente)
        {
            return contexto.Pacientes.FirstOrDefault(p => p.PacienteId == idPaciente);
        }

        public void Cadastrar(Paciente novoPaciente)
        {
            contexto.Pacientes.Add(novoPaciente);
            contexto.SaveChanges();
        }

        public void Deletar(int idUsuario)
        {
            contexto.Pacientes.Remove(BuscarPorId(idUsuario));
            contexto.SaveChanges();
        }

        public List<Paciente> ListarTodos()
        {
            return contexto.Pacientes.ToList();
        }
    }
}
