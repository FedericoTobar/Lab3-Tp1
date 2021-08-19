using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado=0;
            string salida;
            do
            {
                Console.WriteLine("Ingrese un numero decimal");
                double numA = (double)Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero decimal");
                double numB = (double)Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Selecciones a continuacion que operacion desea realizar entre los numeros ingresados");
                String eleccion = Console.ReadLine();
                switch (eleccion)
                {
                    case "+":
                        resultado = suma(numA, numB);
                        break;
                    case "-":
                        resultado = resta(numA, numB);
                        break;
                    case "*":
                        resultado = multiplicacion(numA, numB);
                        break;
                    case "/":
                        resultado = division(numA, numB);
                        break;
                    case "%":
                        resultado = modulo(numA, numB);
                        break;
                    default:
                        Console.WriteLine("Eleccion incorrecta, vuelvaa a intentarlo");
                        break;
                }
                Console.WriteLine("El resultado es: "+resultado);
                Console.WriteLine("Desea salir? Y/N");
                salida = Console.ReadLine();
                if (salida == "Y" || salida == "y") {
                    break;
                }
            } while (true);
        }
        public static double suma(double num1, double num2) {
            return num1 + num2;
        }
        public static double resta(double num1, double num2) {
            if (num1 > num2)
            {
                return num1 - num2;
            }
            else
                return num2 - num1;
        }
        public static double multiplicacion(double num1, double num2) {
            return num1 * num2;
        }
        public static double division(double num1, double num2) {
            if (num1 > num2)
            {
                return num1 / num2;
            }
            else
                return num2 / num1;
        }
        public static double modulo(double num1, double num2) {
            if (num1 > num2)
            {
                return num1 % num2;
            }
            else
                return num2 % num1;
        }
    }
}
