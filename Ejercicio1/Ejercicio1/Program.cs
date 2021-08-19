using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- Muestra los números del 1 al 100 (ambos incluidos) divisibles entre 2 y 5. Utiliza las
            //iteraciones for, while, do/while para resolver el mismo problema.

            for (int i = 1; i < 101; i++)
            {
                if (i % 5 == 0 || i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            int j = 1;
            while (true)
            {
                if (j % 5 == 0 || j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
                if (j > 100)
                {
                    break;
                }
            }

            int k = 1;
            do
            {
                if (k % 5 == 0 || k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            } while (k < 101);
        }
    }
}
