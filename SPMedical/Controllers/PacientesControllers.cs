using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPMedical.Domains;
using SPMedical.Interfaces;
using SPMedical.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesControllers : ControllerBase
    {
        private IPacienteRepository _PacienteRepository { get; set; }
        public PacientesControllers()
        {
            _PacienteRepository = new PacienteRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_PacienteRepository.ListarTodos());
        }

        [HttpGet]
        public IActionResult BuscarPorID(int idPaciente)
        {
            return Ok(_PacienteRepository.BuscarPorId(idPaciente));
        }

        [HttpPost]
        public IActionResult Cadastrar(Paciente novoPaciente)
        {
            _PacienteRepository.Cadastrar(novoPaciente);
            return StatusCode(201);
        }

        [HttpDelete("{PacienteId}")]
        public IActionResult Deletar(int idPaciente)
        {
            _PacienteRepository.Deletar(idPaciente);
            return StatusCode(201);
        }

        [HttpPut("{PacienteId}")]
        public IActionResult Atualizar(int idPaciente, Paciente pacienteAtualizada)
        {
            _PacienteRepository.AtualizarIdUrl(idPaciente, pacienteAtualizada);
            return StatusCode(204);
        }
    }
}
