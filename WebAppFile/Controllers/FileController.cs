using Microsoft.AspNetCore.Mvc;
using WebAppFile.Interface;

namespace WebAppFile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly IFile _file;

        public FileController(IFile file)
        {
            _file = file;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _file.Save("logA.txt", "Hello World");
            return Ok();
        }
    }
}
