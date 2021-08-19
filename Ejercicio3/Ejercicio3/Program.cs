using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3- Codifique un método denominado esPar que reciba como parámetro un valor
            //numérico entero y retorne true en caso de que el numero sea par, caso contrario
            //retorne false.Compruebe el funcionamiento del método solicitando al usuario del
            //programa que ingrese números aleatorios.
            Boolean condicion = false;
            while (true)
            {
                Console.WriteLine("Ingrese numero paraa comprobar si ¡es par!");
                int numero = Convert.ToInt32(Console.ReadLine());
                condicion=esPar(numero);
                if (condicion == true) {
                    Console.WriteLine("el numero " + numero + " es par");
                }else
                    Console.WriteLine("el numero " + numero + " es impar");
                Console.WriteLine("Desea salir? Y/N");
                String salir = Console.ReadLine();
                if (salir == "Y") {
                    break;
                }
            }
        }
        public static bool esPar(int num) {
            if (num % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
