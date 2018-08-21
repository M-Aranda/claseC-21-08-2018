using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase218.herencia
{
    public class Docente : Trabajador
    {
        String titulo;

        public string Titulo { get => titulo; set => titulo = value; }
    }
}
