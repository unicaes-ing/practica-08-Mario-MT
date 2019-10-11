using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8CS
{
    class Ejercicio1
    {
        public struct Estudiante
        {
            public string carnet;
            public string nombre;
            public string carrera;
            private decimal cum;

            public void setCum(decimal cum)
            {
                if (cum >= 0 && cum <= 10)
                {
                    this.cum = cum;
                }
            }

            public decimal getCum()
            {
                return cum;
            }
        }
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();
            Console.Write("Ingrese el nombre del estudiante: ");
            estudiante.nombre = Console.ReadLine();
            Console.Write("Digite su carnet: ");
            estudiante.carnet = Console.ReadLine();
            Console.Write("Ingrese a la carrera a la cual pertenece: ");
            estudiante.carrera = Console.ReadLine();
            Console.Write("Ingrese su CUM: ");
            estudiante.setCum(Convert.ToDecimal(Console.ReadLine()));
            Console.Clear();

            Console.WriteLine("Estudiante: " + estudiante.nombre);
            Console.WriteLine("Carnet: " + estudiante.carnet);
            Console.WriteLine("Carrera: " + estudiante.carrera);
            Console.WriteLine("CUM: " + estudiante.getCum());
            Console.ReadKey();
        }
    }
}
