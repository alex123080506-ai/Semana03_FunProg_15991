using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short num1 = 10;
            short num2;
            short suma;
            short resta;

            Console.Write("Ingrese numero 2:");
            num2= short.Parse(Console.ReadLine());
            
            suma= (short)(num1 + num2);
            resta= (short)(num1 - num2);
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La resta es: " + resta);
















        }
    }
}
