using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase218.herencia;
using clase218.interfaces;

namespace clase218
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            Trabajador t = new Trabajador();
            Docente d = new Docente();

            p.Rut = "20898088-2";
            p.Nombre = "Marcelo";
            p.Edad = 26;


            t.Rut = "20898088-1";
            t.Nombre = "Gonzalo";
            t.Edad = 23;
            t.Sueldo = 10000000;
            t.TipoContrato = "Indefinido";


            d.Rut = "20898088-1";
            d.Nombre = "Faker";
            d.Edad = 23;
            d.Sueldo = 10000000;
            d.TipoContrato = "Indefinido";
            d.Titulo = "Preparador fisico";

            Console.WriteLine("Rut: "+p.Rut+" Nombre: "+p.Nombre+" Edad:"+p.Edad);
            Console.WriteLine(t.Nombre);
            Console.WriteLine(d.Nombre);

            Cuadrado c = new Cuadrado();
            c.Lado =2;

            Rectangulo r = new Rectangulo();
            r.Largo = 3;
            r.Ancho = 5;

            Console.WriteLine("Perimetro:" +c.GetPerimetro()+" Area: "+c.GetArea());
            Console.WriteLine("Perimetro:"+r.GetPerimetro() + " Area: " + r.GetArea());

            var name = Console.ReadLine();


        }
    }
}
