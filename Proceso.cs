using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Primos_2._0
{
    class Proceso
    {
        public int determiar_rango(int a)
        {
            Proceso opr = new Proceso();
            Menu1 me = new Menu1();
            if (a == 1)
            {
                Console.WriteLine("____________________________________________");
                Console.Write("   Ingrese el valor minimo del Rango: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("   Ingrese el valor maximo del Rango: ");
                int rangomax = int.Parse(Console.ReadLine());
                Console.WriteLine("____________________________________________");
                opr.rango(numero, rangomax);
                a = 9;
            }
            else if (a == 2)
            {
                opr.rango(1, 100);
                a = 9;
            }
            else if (a == 3)
            {
                opr.rango(1, 1000);
                a = 9;
            }
            else if (a == 4)
            {
                a = 0;
            }
            Console.ReadKey();
            Console.Clear();
            return a;
        }
        public void rango(int a, int b, int c = 0)
        {
            Console.WriteLine("    Numero Primos del rango " + a + " al " + b);
            while (a <= b)
            {
                for (int i = 1; i <= a; i++)
                {
                    if (a % i == 0)
                    {
                        c++;
                    }
                    if (c > 2)
                    {
                        break;
                    }
                }
                if (c == 2)
                {
                    Console.WriteLine("    "+ a + " es primo" + "    ");
                }
                c = 0;
                a++;
            }
        }
    }
}
