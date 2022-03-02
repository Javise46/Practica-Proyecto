using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practica_Proyecto
{
    class Menu1
    {
        public int menu(int a)
        {
            
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("\t\t\t\t____________________________________________");
            Console.WriteLine("\t\t\t\t\t\tNumeros Primos");
            Console.WriteLine
                (
                "\n\t\t\t\t 1. Buscar Numeros Primos dentro de un rango. " +
                "\n\t\t\t\t 2. Buscar Numeros del 1 al 100." +
                "\n\t\t\t\t 3. Buscar Numeros del 1 al 1000. " +
                "\n\t\t\t\t 4. Salir"
                );
            Console.Write("\t\t\t\t\t\t\t ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            a = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\t\t\t\t____________________________________________");
            return a;
        }
        public void credits()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("\t\t\t\t____________________________________________");
            Console.WriteLine("\t\t\t\t  ----------------Creditos----------------");
            Console.WriteLine("\t\t\t\t    Adinson Melvin David Morales Pineda");
            Console.WriteLine("\t\t\t\t   Pedro Javier Serrano Ramírez (Javise46) ");
            Console.WriteLine("\t\t\t\t____________________________________________");
            Console.ReadKey();
        }
        public static int[] Rangos(int a=0, int b=0)
        {
            int[] ab = new int [2];
            Console.WriteLine("\t\t\t\t____________________________________________");

            Console.Write("\t\t\t\t  Ingrese el valor minimo del Rango: ");
            Console.ForegroundColor = ConsoleColor.Red;
             ab[0] = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" \t\t\t\t  Ingrese el valor maximo del Rango: ");
            Console.ForegroundColor = ConsoleColor.Red;
             ab[1] = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t____________________________________________");
            return ab;
        }

    }
}
