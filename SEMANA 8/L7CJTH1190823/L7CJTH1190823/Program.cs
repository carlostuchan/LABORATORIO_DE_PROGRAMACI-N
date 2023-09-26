using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7CJTH1190823
{
    using System;

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese un número entero mayor que 0:");
            int N;

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out N) && N > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Ingrese un número entero mayor que 0:");
                }
            }

            int a = 0, b = 1;
            int count = 0; 

            
            Console.WriteLine("Sucesión de Fibonacci hasta el término " + N + ":");
            while (count < N)
            {
                Console.Write(a + " ");

                int temp = a;
                a = b;
                b = temp + b;

                count++;
            }

            Console.ReadLine(); 
        }
    }
}