using System;

namespace Ejercicio1Aritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso a - Mostrar el mensaje
            Console.WriteLine("Ejercicio 1: Operaciones Aritméticas");

            // Paso b - Pedir al usuario que ingrese dos números
            Console.Write("Ingrese el primer número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            // Paso c - Realizar las operaciones aritméticas
            double suma = numero1 + numero2;
            double resta = numero1 - numero2;
            double multiplicacion = numero1 * numero2;
            double division = numero1 / numero2;
            double division_entera = Math.Floor(numero1 / numero2);
            double modulo = numero1 % numero2;

            // Paso d - Mostrar los resultados de las operaciones aritméticas
            Console.WriteLine($"{numero1} + {numero2} = {suma}");
            Console.WriteLine($"{numero1} - {numero2} = {resta}");
            Console.WriteLine($"{numero1} * {numero2} = {multiplicacion}");
            Console.WriteLine($"{numero1} / {numero2} = {division}");
            Console.WriteLine($"{numero1} div {numero2} = {division_entera}");
            Console.WriteLine($"{numero1} mod {numero2} = {modulo}");

            // Agregar el mensaje para el ejercicio 2
            Console.WriteLine("Ejercicio 2: Operaciones Booleanas");

            // Paso c - Realizar las operaciones booleanas
            bool mayorQue = numero1 > numero2;
            bool menorQue = numero1 < numero2;
            bool igualdad = numero1 == numero2;

            // Paso d - Mostrar los resultados de las operaciones booleanas
            Console.WriteLine($"{numero1} > {numero2} = {mayorQue}");
            Console.WriteLine($"{numero1} < {numero2} = {menorQue}");
            Console.WriteLine($"{numero1} == {numero2} = {igualdad}");

            // Agregar el mensaje para el ejercicio 3
            Console.WriteLine("Ejercicio 3: Jerarquía de Operaciones");

            // Paso a - Permitir al usuario ingresar tres números
            Console.Write("Ingrese el primer número (a): ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número (b): ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer número (c): ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Verificar las condiciones ideales
            if (a != 0 && (Math.Pow(b, 2) - 4 * a * c) >= 0)
            {
                // Calcular el discriminante
                double discriminante = Math.Pow(b, 2) - 4 * a * c;

                // Calcular las dos soluciones
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                // Mostrar las soluciones
                Console.WriteLine($"Las soluciones de la ecuación cuadrática son:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else
            {
                Console.WriteLine("Error: La ecuación cuadrática no cumple con las condiciones ideales.");
            }
        }
    }
}
