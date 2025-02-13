using Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Model.Usuarios;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilesController : ControllerBase
    {
        private readonly PerfilesServices _perfilesServices;

        public PerfilesController(PerfilesServices perfilesServices)
        {
            _perfilesServices = perfilesServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Perfil>>> GetPerfiles()
        {
            return await _perfilesServices.GetPerfilesAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Perfil>> CrearPerfil(Perfil perfil)
        {
            bool respuesta = await _perfilesServices.CrearPerfil(perfil);
            return Ok(respuesta);
        }
    }
}
