using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string linea;
            Console.Write("Ingrese un numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            if (num1 % 2 == 0)
            {
            Console.Write("Este numero es par");
            } 
            else
            {
            Console.Write("El numero es impar");
            }
            Console.ReadKey();
        }
    }
}
