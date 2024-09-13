using Microsoft.AspNetCore.Mvc;
using WebAppFile.Interface;

namespace WebAppFile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileTypeAController : ControllerBase
    {
        private readonly IFile _file;

        public FileTypeAController(IFileFactory fileFactory)
        {
            _file = fileFactory.CreateFile("A");
        }

        [HttpGet]
        public IActionResult Get()
        {
            _file.Save("logA.txt", "Hello World");
            return Ok();
        }
    }
}
