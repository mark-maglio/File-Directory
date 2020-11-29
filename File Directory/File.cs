using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Directory
{
    class File : FileAstratto
    {
        public long Dimensione { get; set; }

        public File(string nome, Directory d) : base(nome, d) { }
    }
}
