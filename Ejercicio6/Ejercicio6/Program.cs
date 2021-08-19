using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programar un algoritmo recursivo que en cada recursión multiplique a si mismo un
            //número ingresado por el usuario hasta que el valor resultante sea mayor

            Console.WriteLine("Ingrese un numero para multiplicarse a si mismo hasta 100.000.000");
            int numeroElejido = Convert.ToInt32(Console.ReadLine());
            int numerofinal = Rec(numeroElejido);
            Console.WriteLine("Numero alcanzado: " + numerofinal);
        }
        public static int Rec(int num)
        {
            int limite = 100000000, contador=0;
            num = num * num;
            contador++;
            if (num > limite)
            {
                Console.WriteLine("numero de vueltas: " + contador);
                return num;
            }
            return Rec(num);
        }
    }
}
