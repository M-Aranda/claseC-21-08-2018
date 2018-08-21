using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase218.interfaces
{
    class Rectangulo : IFigura
    {
        int largo;
        int ancho;

        public int Largo { get => largo; set => largo = value; }
        public int Ancho { get => ancho; set => ancho = value; }

        public int GetArea()
        {
            return largo * ancho;
        }

        public int GetPerimetro()
        {
            return (largo * 2) + (ancho * 2);
        }
    }
}
