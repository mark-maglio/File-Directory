using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Directory
{
    class FileAstratto
    {
        public string Nome { get; private set; }
        public FileAstratto(string nome, Directory d)
        {
            Nome = nome;
        }

        public abstract long GetDimensione();
        public abstract string GetNome();

        public abstract Directory GetPadre();

        public string Stampa(Directory d)
        {
            return Nome;
        }
    }
}
