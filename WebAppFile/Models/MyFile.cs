using WebAppFile.Interface;

namespace WebAppFile.Models
{
    public class MyFile: IFile
    {
        private readonly string _folder;
        public MyFile(string folder)
        {
            _folder = folder;
        }

        public void Save(string file, string content)
        {
            var fullPath = Path.Combine(_folder, file);
            System.IO.File.WriteAllText(fullPath, content);
        }
    }
}
