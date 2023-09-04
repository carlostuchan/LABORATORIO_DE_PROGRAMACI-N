using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1CJTH1190823
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo soy Carlos");
            Console.ReadKey();

            Console.WriteLine("Hola mundo");
            Console.WriteLine("Soy Carlos");

            /*WriteLine sirve para poner un texto en una linea específica, separandolo de otro texto. En cambio Write no separa el texto y lo coloca en una misma linea y sin espacios.*/

            Console.Write("Hola Mundo");
            Console.Write("Soy Carlos");
            Console.ReadKey();

            Console.WriteLine("Ingrese su nombre:  ");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Hola mundo");
            Console.WriteLine("soy " + Nombre);

            Console.Write("Hola mundo");
            Console.Write("soy " + Nombre);
            Console.ReadKey();

      
        }
    }
}
