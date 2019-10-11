using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8CS
{
    class Ejercicio3
    {
        public struct Materia
        {
            public string nombre;
            private double nota;
            public void setNota(double nota)
            {
                if (nota < 7.0)
                {
                    this.nota = nota;
                }
                else
                {
                    this.nota = nota;
                }

            }
            public double getNota()
            {
                if (nota < 7.0)
                {
                    Console.WriteLine("Reprobado");

                }
                else
                {
                    Console.WriteLine("Aprobado");

                }
                return nota;
            }
        }
        public struct Alumno
        {
            public string carnet;
            public string nombre;
            public string carrera;
            public Materia materia1;
            public Materia materia2;
            public Materia materia3;
            public Materia materia4;
        }
        static void Main(string[] args)
        {
            int cant;
            Console.Write("¿Cuantos alumnos son?: ");
            cant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Alumno[] alum = new Alumno[cant];
            for (int c = 0; c < alum.Length; c++)
            {
                Console.Write("Alumno N°{0}", c + 1);
                Console.Write("\nNgrese el carnet del Alumno: ");
                alum[c].carnet = Console.ReadLine();
                Console.Write("\nIngrese el nombre del Alumno: ");
                alum[c].nombre = Console.ReadLine();
                Console.Write("\nIngrese la carrera del alumno: ");
                alum[c].carrera = Console.ReadLine();

                Console.Write("\nNota de materia 1: ");
                alum[c].materia1.setNota(Convert.ToDouble(Console.ReadLine()));
                Console.Write("\nNota de materia 2: ");
                alum[c].materia2.setNota(Convert.ToDouble(Console.ReadLine()));
                Console.Write("\nNota de materia 3: ");
                alum[c].materia3.setNota(Convert.ToDouble(Console.ReadLine()));
                Console.Write("\nNota de materia 4: ");
                alum[c].materia4.setNota(Convert.ToDouble(Console.ReadLine()));
            }
            Console.WriteLine("\nPresione <ENTER> para continuar");
            Console.ReadKey();
            Console.Clear();
            int n = 0;
            foreach (Alumno a in alum)
            {
                n++;
                Console.WriteLine("Datos del Alumno n°{0}", n);
                Console.WriteLine("Carnet: {0}", a.carnet);
                Console.WriteLine("Nombre: {0}", a.nombre);
                Console.WriteLine("Carrera: {0}", a.carrera);
                Console.WriteLine("Materias aprobadas y reprobadas");
                Console.WriteLine();
                Console.WriteLine("Nota materia 1: {0}", a.materia1.getNota());
                Console.WriteLine("Nota Materia 2: {0}", a.materia2.getNota());
                Console.WriteLine("Nota Materia 3: {0}", a.materia3.getNota());
                Console.WriteLine("Nota Materia 4: {0}", a.materia4.getNota());
                Console.ReadLine();
            }
        }
    }
}
