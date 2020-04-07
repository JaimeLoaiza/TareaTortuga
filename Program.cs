using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTortuga
{
    class Program
    {
        static void Main(string[] args)
        {
            Tortugas tortuga = new Tortugas();
            Console.WriteLine("Digite el Nombre de la Tortuga");
            tortuga.SetNombre(Console.ReadLine());
            Console.WriteLine("Digite la Especie de la Tortuga");
            tortuga.Especie = Console.ReadLine();
            Console.WriteLine("Digite la Clasificación de la tortuga");
            tortuga.Clasificacion = Console.ReadLine();
            Console.WriteLine("La Información Suministrada fue:");
            Console.WriteLine("Nombre: {0}", tortuga.GetNombre());
            Console.WriteLine("Especie: {0}", tortuga.Especie);
            Console.WriteLine("Clasificación: {0}", tortuga.Clasificacion);
            Console.ReadKey();
        }
    }
}
