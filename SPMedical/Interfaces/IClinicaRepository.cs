using SPMedical.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Interfaces
{
    interface IClinicaRepository
    {
        List<Clinica> ListarTodos();
        Clinica BuscarPorId(int idClinica);
        void Cadastrar(Clinica novoClinica);
        void AtualizarIdCorpo(Clinica clinicaAtualizada);
        void AtualizarIdUrl(int idClinica, Clinica clinicaAtualizada);
        void Deletar(int idUsuario);
    }
}
