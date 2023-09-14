class Program
{
    static void Main(string[] args)
    {
        // Imprimir "Ejercicio 2"
        Console.WriteLine("Ejercicio 2");

        // Solicitar al usuario ingresar el número de día
        Console.Write("Ingrese un número de día (1-lunes, 2-martes, 3-miércoles, 4-jueves, 5-viernes, 6-sábado, 7-domingo): ");
        int numeroDia = int.Parse(Console.ReadLine());

        // Comprobar si el número está dentro del rango válido (1-7)
        if (numeroDia >= 1 && numeroDia <= 7)
        {
            // Asignar números a días de la semana
            if (numeroDia == 1)
                Console.WriteLine("DIA: " + numeroDia + " Lunes"); ;
            if (numeroDia == 2)
                Console.WriteLine("DIA: " + numeroDia + " Martes");
            if (numeroDia == 3)
                Console.WriteLine("DIA: " + numeroDia + " Miercoles");
            if (numeroDia == 4)
                Console.WriteLine("DIA: " + numeroDia + " Jueves");
            if (numeroDia == 5)
                Console.WriteLine("DIA: " + numeroDia + " Viernes");
            if (numeroDia == 6)
                Console.WriteLine("DIA: " + numeroDia + " Sábado");
            if (numeroDia == 7)
                Console.WriteLine("DIA: " + numeroDia + " Domingo");

            {

            }
            // Mostrar el resultado en pantalla
        }
        else
        {
            // Mostrar un mensaje de error si el número está fuera del rango
            Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
        }
    }
}