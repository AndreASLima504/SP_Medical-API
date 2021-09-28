using SPMedical.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Interfaces
{
    interface IPacienteRepository
    {
        List<Paciente> ListarTodos();
        Paciente BuscarPorId(int idPaciente);
        void Cadastrar(Paciente novoPaciente);
        void AtualizarIdCorpo(Paciente pacienteAtualizada);
        void AtualizarIdUrl(int idPaciente, Paciente pacienteAtualizada);
        void Deletar(int idUsuario);
    }
}
