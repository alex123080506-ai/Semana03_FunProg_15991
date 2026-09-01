using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t1, t2, t3, ep, ef;
            float promedio;
            Console.Write("ingrese nota T1: ");
            t1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nota T2: ");
            t2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrse nota T3: ");
            t3 = int.Parse(Console.ReadLine());
            Console.Write("ingrese nota de EP: ");
            ep = int.Parse(Console.ReadLine());
            Console.Write("Ingrse nota de EF: ");
            ef = int.Parse(Console.ReadLine());
            promedio = (float)(t1 * 0.10f) + (t2 * 0.10f) + (t3 * 0.10f) + (ep * 0.20f) + (ef * 0.50f);
            Console.WriteLine("El promedio es:" + promedio);
            Console.WriteLine("El promedio redondeado es:" +
                Math.Round(promedio));

            if (promedio >= 11.5)
                Console.WriteLine("Usted esta aprobado");
            else
             Console.WriteLine("Usted esta desaprobado");

        }
    }
}
