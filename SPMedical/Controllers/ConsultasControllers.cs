using Microsoft.AspNetCore.Authorization;
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
    public class ConsultasControllers : Controller
    {

        private IConsultaRepository _consultaRepository { get; set; }
        public ConsultasControllers()
        {
            _consultaRepository = new ConsultaRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_consultaRepository.ListarTodos());
        }
        
        [HttpGet]
        public IActionResult BuscarPorID(int idConsulta)
        {
            return Ok(_consultaRepository.BuscarPorId(idConsulta));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Consulta novoConsulta)
        {
            _consultaRepository.Cadastrar(novoConsulta);
            return StatusCode(201);
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{ConsultaId}")]
        public IActionResult Deletar(int idConsulta)
        {
            _consultaRepository.Deletar(idConsulta);
            return StatusCode(201);
        }
        [Authorize(Roles = "1")]
        [HttpPut("{ConsultaId}")]
        public IActionResult Atualizar(int idConsulta, Consulta consultaAtualizada)
        {
            _consultaRepository.AtualizarIdUrl(idConsulta, consultaAtualizada);
            return StatusCode(204);
        }
    }
}
   