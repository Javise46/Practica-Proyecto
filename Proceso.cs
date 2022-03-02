using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Proyecto
{
    class Proceso
    {
        public int determiar_rango(int a)
        {
            Proceso opr = new Proceso();
            Menu1 me = new Menu1();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            
            if (a == 1)
            {
                
                int[] b = Menu1.Rangos();
                
                opr.rango(b[0], b[1]);
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
            
            return a;
        }
        public void rango(int a, int b, int c = 0)
        {
           
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("   \t\t\t\t\t Numero Primos del rango " + a + " al " + b);
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            
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
                    Console.WriteLine("\t\t\t\t\t\t" + a + " es primo.");
                }
                c = 0;
                a++;
            }
        }
    }
}
