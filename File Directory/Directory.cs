using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Directory
{
    public class Directory : FileAstratto
    {
        List<File> Files = new List<File>();
        public Directory(string nome, Directory directory) : base(nome, directory) { }

        public List<File> GetFiles()
        {
            return Files;
        }
        public void AddFile(File file)
        {
            Files.Add(file);
        }
    }
}
