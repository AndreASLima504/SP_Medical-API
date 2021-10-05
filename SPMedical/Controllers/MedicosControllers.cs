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
    public class MedicosControllers : ControllerBase
    {
        private IMedicoRepository _clinicaRepository { get; set; }
        public MedicosControllers()
        {
            _clinicaRepository = new MedicoRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_clinicaRepository.ListarTodos());
        }

        [HttpGet]
        public IActionResult BuscarPorID(int idMedico)
        {
            return Ok(_clinicaRepository.BuscarPorId(idMedico));
        }

        [HttpPost]
        public IActionResult Cadastrar(Medico novoMedico)
        {
            _clinicaRepository.Cadastrar(novoMedico);
            return StatusCode(201);
        }

        [HttpDelete("{MedicoId}")]
        public IActionResult Deletar(int idMedico)
        {
            _clinicaRepository.Deletar(idMedico);
            return StatusCode(201);
        }

        [HttpPut("{MedicoId}")]
        public IActionResult Atualizar(int idMedico, Medico medicoAtualizado)
        {
            _clinicaRepository.AtualizarIdUrl(idMedico, medicoAtualizado);
            return StatusCode(204);
        }
    }
}
