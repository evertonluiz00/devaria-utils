using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiModel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult BuscarUsuario()
        {
            var usuario = new Usuario()
            {
                Nome = "Juca",
                Email = "juca@gmail.com",
                Senha = "123456"
            };

            return Ok(usuario);
        }

        [HttpGet("listar")]
        public IActionResult ListarUsuarios()
        {
            string[] listaNomes = { "Rafael", "Daniel", "Kaique", "Adriano", "Filipe" };
            return Ok(listaNomes);
        }
    }
}
