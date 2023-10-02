using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9CJTH1190823
{
    internal class Program
 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero mayor que 0:");
            int N;

            // Validar que se ingrese un número válido
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero mayor que 0:");
            }

            Console.WriteLine("La sumatoria de los números del 1 al " + N + " es: " + CalcularSumatoria(N));

            Console.WriteLine("\nTablas de multiplicar del 1 al 10:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("\nTabla del " + i + ":\t");

                for (int j = 1; j <= N; j++)
                {
                    Console.Write(i * j + "\t");
                }
            }

            Console.ReadLine();
        }

        static int CalcularSumatoria(int n)
        {
            int suma = 0;
            int i = 1;

            do
            {
                suma += i;
                i++;
            } while (i <= n);

            return suma;
        }
    }
}
