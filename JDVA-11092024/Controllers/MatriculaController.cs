using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace JDVA_11092024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    [Authorize]
    public class MatriculaController : ControllerBase
    {
        static List<object> data = new List<object>();

        [HttpGet]
        public IEnumerable<object> Get()
        {
            return data;
        }

        [HttpPost]
        public IActionResult Post(string nombreEstudiante, string carrera , string grupo)
        {
            data.Add(new { nombreEstudiante, carrera, grupo});
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            data = new List<object>();
            return Ok();
        }
    }
}
