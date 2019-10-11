using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8CS
{
    class Ejercicio2
    {
        public struct Producto
        {
            public string nombre;
            private int cantidad;
            private decimal precio;

            public void setCantidad(int cantidad)
            {
                if (cantidad > 0)
                {
                    this.cantidad = cantidad;
                }
            }

            public int getCantidad()
            {
                return cantidad;
            }

            public void setPrecio(decimal precio)
            {
                if (precio > 0)
                {
                    this.precio = precio;
                }
            }

            public decimal getPrecio()
            {
                return precio * 1.13m * cantidad;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de productos: ");
            int produc = Convert.ToInt32(Console.ReadLine());
            Producto[] prod = new Producto[produc];
            for (int i = 0; i < produc; i++)
            {
                Console.Clear();
                Console.WriteLine("Producto N°" + (i + 1));
                Console.Write("Nombre: ");
                prod[i].nombre = Console.ReadLine();
                Console.Write("Cantidad: ");
                prod[i].setCantidad(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Precio: $");
                prod[i].setPrecio(Convert.ToDecimal(Console.ReadLine()));
            }
            Console.Clear();
            int n = 0;
            foreach (var producto in prod)
            {
                Console.WriteLine("Producto N°" + (n + 1));
                Console.WriteLine("\nNombre: " + prod[n].nombre);
                Console.WriteLine("Cantidad: " + prod[n].getCantidad());
                Console.WriteLine("Precio con IVA incluido: " + prod[n].getPrecio().ToString("C2"));
                Console.WriteLine();
                n++;
            }
            Console.ReadKey();
        }
    }
}
