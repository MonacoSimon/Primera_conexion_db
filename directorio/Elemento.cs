using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using directorio;

namespace directorio
{
    public class Elemento
    {
        public int id { get; set; }

        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
