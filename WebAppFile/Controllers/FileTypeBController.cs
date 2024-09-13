using Microsoft.AspNetCore.Mvc;
using WebAppFile.Interface;

namespace WebAppFile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileTypeBController : ControllerBase
    {
        private readonly IFile _file;

        public FileTypeBController(IFileFactory fileFactory)
        {
            _file = fileFactory.CreateFile("B");
        }

        [HttpGet]
        public IActionResult Get()
        {
            _file.Save("logB.txt", "Hello World");
            return Ok();
        }
    }
}
