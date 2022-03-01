using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceso opr = new Proceso();
            Menu1 me = new Menu1();
            int op = 9;
            while (op != 0)
            { 
                op = me.menu(op);
                op = opr.determiar_rango(op);
            }
            me.credits();
        }
    }
}