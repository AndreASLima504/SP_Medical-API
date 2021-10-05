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
    public class TipoUsuariosControllers : ControllerBase
    {
        private ITipoUsuarioRepository _tipoUsuarioRepository { get; set; }
        public TipoUsuariosControllers()
        {
            _tipoUsuarioRepository = new TipoUsuarioRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_tipoUsuarioRepository.ListarTodos());
        }

        [HttpGet]
        public IActionResult BuscarPorID(int idTipoUsuario)
        {
            return Ok(_tipoUsuarioRepository.BuscarPorId(idTipoUsuario));
        }

        [HttpPost]
        public IActionResult Cadastrar(TipoUsuario novoTipoUsuario)
        {
            _tipoUsuarioRepository.Cadastrar(novoTipoUsuario);
            return StatusCode(201);
        }

        [HttpDelete("{TipoUsuarioId}")]
        public IActionResult Deletar(int idTipoUsuario)
        {
            _tipoUsuarioRepository.Deletar(idTipoUsuario);
            return StatusCode(201);
        }

        [HttpPut("{TipoUsuarioId}")]
        public IActionResult Atualizar(int idTipoUsuario, TipoUsuario tipoUsuarioAtualizado)
        {
            _tipoUsuarioRepository.AtualizarIdUrl(idTipoUsuario, tipoUsuarioAtualizado);
            return StatusCode(204);
        }
    }
}
