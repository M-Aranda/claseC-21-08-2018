using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase218.interfaces
{
     class Cuadrado : IFigura
    {
        int lado;

        public int Lado { get => lado; set => lado = value; }

        public int GetArea()
        {
            return Lado * Lado;
            
        }

        public int GetPerimetro()
        {
            return 4 * Lado;
        }
    }
}
