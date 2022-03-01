using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Numeros_Primos_2._0
{
    class Menu1
    {
        public int menu(int a)
        {
            Console.WriteLine("____________________________________________");
            Console.WriteLine(" 1. Buscar Numeros Primos dentro de un rango. \n 2. Buscar Numeros del 1 al 100.\n 3. Buscar Numeros del 1 al 1000. \n 4. Salir");
            a = int.Parse(Console.ReadLine());


            Console.WriteLine("____________________________________________");
            return a;
        }
        public void credits(int a = 0)
        {
            Console.WriteLine("____________________________________________");
            Console.WriteLine("  ----------------Creditos----------------");
            Console.WriteLine("    Adinson Melvin David Morales Pineda");
            Console.WriteLine("   Pedro Javier Serrano Ramírez (Javise46) ");
            Console.WriteLine("____________________________________________");
            Console.ReadKey();
        }

    }
}
