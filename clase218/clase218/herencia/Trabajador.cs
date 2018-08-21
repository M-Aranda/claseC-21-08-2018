using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase218.herencia
{
    public class Trabajador : Persona
    {
       
        long sueldo;
        String tipoContrato;

        public long Sueldo { get => sueldo; set => sueldo = value; }
        public string TipoContrato { get => tipoContrato; set => tipoContrato = value; }
    }
}
