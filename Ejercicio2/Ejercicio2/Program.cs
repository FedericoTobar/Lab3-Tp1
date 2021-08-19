using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2- Codifique un programa de consola en C# que permita realizar las siguientes acciones:
            //Generar un número aleatorio entre 0 y 100, para ello use la función random de C#
            //Una vez generado el número codifique la lógica necesaria para encontrar el número
            //aleatorio ayudando al usuario informando al mismo si el número ingresado es mayor o
            //menor al número aleatorio buscado. Una vez encontrado el número muestre la cantidad
            //de intentos necesarios para lograrlo.
            int num, eleccion, contador = 0;
            var numeroRandom = new Random();
            num = numeroRandom.Next(0, 101);
            while (true)
            {
                Console.WriteLine("Encuentre el numero, elija un numero...");
                eleccion = Convert.ToInt32(Console.ReadLine());
                if (eleccion == num)
                {
                    Console.WriteLine("Acertó el numero!!! Felicitaciones");
                    break;
                }
                else
                {
                    if (Math.Abs(num - eleccion) < 10)
                    {
                        Console.WriteLine("Muy cerca del valor");
                    }
                    else if (Math.Abs(num - eleccion) < 25)
                    {
                        Console.WriteLine("Cerca del valor");
                    }
                    else
                        Console.WriteLine("Valor lejano");

                }
                contador++;
            }
            Console.WriteLine("Numero de intentos: " + contador);
        }
    }
}
