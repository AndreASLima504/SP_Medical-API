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
    public class ClinicasControllers : ControllerBase
    {
        private IClinicaRepository _clinicaRepository { get; set; }
        public ClinicasControllers()
        {
            _clinicaRepository = new ClinicaRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_clinicaRepository.ListarTodos());
        }

        [HttpGet]
        public IActionResult BuscarPorID(int idClinica)
        {
            return Ok(_clinicaRepository.BuscarPorId(idClinica));
        }

        [HttpPost]
        public IActionResult Cadastrar(Clinica novoClinica)
        {
            _clinicaRepository.Cadastrar(novoClinica);
            return StatusCode(201);
        }

        [HttpDelete("{ClinicaId}")]
        public IActionResult Deletar(int idClinica)
        {
            _clinicaRepository.Deletar(idClinica);
            return StatusCode(201);
        }

        [HttpPut("{ClinicaId}")]
        public IActionResult Atualizar(int idClinica, Clinica clinicaAtualizada)
        {
            _clinicaRepository.AtualizarIdUrl(idClinica, clinicaAtualizada);
            return StatusCode(204);
        }


    }
}
