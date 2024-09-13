using WebAppFile.Models;

namespace WebAppFile.Interface
{
    public class FileFactory : IFileFactory
    {
        public IFile CreateFile(string parametro)
        {
            return new MyFile(parametro);
        }
    }

}
