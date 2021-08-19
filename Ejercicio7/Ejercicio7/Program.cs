using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explique y ejemplifique los métodos para el manejo de cadenas en C#, Lenght,
            //Contains, IndexOf, Remove, Replace, Substring, Append, ToUpper, ToLower.
            String frase = "Hola, este es el primer TP";
            int largo = frase.Length;
            Console.WriteLine("Largo de la frase: " + largo);
            if (frase.Contains("Hola")) {
                Console.WriteLine("La frase saluda");
            }
            Console.WriteLine("Lugar donde se encuentra TP en la frase?" +frase.IndexOf("TP"));
            frase.Remove(0,10);
            Console.WriteLine(frase);
            frase.Replace('H', 'h');
            Console.WriteLine(frase);
            Console.WriteLine(frase.Substring(5));
            Console.WriteLine(frase.ToUpper());
            Console.WriteLine(frase.ToLower());

        }
    }
}
