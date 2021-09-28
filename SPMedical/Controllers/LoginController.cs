using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPMedical.Interfaces;
using SPMedical.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedical.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        private IUsuarioRepository _usuarioRepository { get; set; }
    }
}
