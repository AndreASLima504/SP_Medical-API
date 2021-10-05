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
    public class UsuariosControllers : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }
        public UsuariosControllers()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_usuarioRepository.ListarTodos());
        }

        [HttpGet]
        public IActionResult BuscarPorID(int idUsuario)
        {
            return Ok(_usuarioRepository.BuscarPorId(idUsuario));
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario novoUsuario)
        {
            _usuarioRepository.Cadastrar(novoUsuario);
            return StatusCode(201);
        }

        [HttpDelete("{UsuarioId}")]
        public IActionResult Deletar(int idUsuario)
        {
            _usuarioRepository.Deletar(idUsuario);
            return StatusCode(201);
        }

        [HttpPut("{UsuarioId}")]
        public IActionResult Atualizar(int idUsuario, Usuario usuarioAtualizado)
        {
            _usuarioRepository.AtualizarIdUrl(idUsuario, usuarioAtualizado);
            return StatusCode(204);
        }
    }
}
