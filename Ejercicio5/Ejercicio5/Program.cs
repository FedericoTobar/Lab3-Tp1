using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cree las funciones necesarias para Calcular el sueldo de los trabajadores
            //dependiendo las horas trabajadas.El valor de la hora en horario diurnos(8:00 a
            //20:00) es de $10 / hora, si el horario es nocturno(20:00 a 8:00) se incrementa en un
            //50 %.El programa debe pedir al usuario en que horario trabajo el empleado(hora
            //ingreso, minuto ingreso, hora salida, minuto salida), validar que la hora/ minuto de
            //ingreso no sea mayor a la hora/ minuto de salida, validar que la cantidad de horas
            //trabajadas no supere las 8 horas, calcular cuantas horas trabajo en total y cuanto
            //corresponde pagarle. Nota: Se recomienda calcular el tiempo laboral en minutos.

            Console.WriteLine("Ingrese la hora de ingreso del trabajador Ej formato 08:43");
            String ingreso = Console.ReadLine();
            Console.WriteLine("Ingrese la hora de egreso del trabajador Ej formato 16:30");
            String egreso = Console.ReadLine();
            int ingresoMin = convertir(ingreso);
            //Console.WriteLine(ingresoMin);
            int egresoMin = convertir(egreso);
            int totalMinTrabajado = egresoMin - ingresoMin;
            double totalPago=0;
            if (totalMinTrabajado < (8 * 60))
            {
                if (ingresoMin > (8 * 60))
                {
                    totalPago = (totalMinTrabajado / 60) * 10;
                }
                else
                    totalPago = (totalMinTrabajado / 60) * 15;
            }
            else
                Console.WriteLine("Turno trabajado mayor a 8 horas");
            Console.WriteLine("Total a pagar por turno trabajado: " + totalPago);
        }
        public static int convertir(string hora) {
            int minutosTotales;
            char separador = ':';
            string[] valores = hora.Split(separador);
            int horas = Convert.ToInt32(valores[0]);
            int minutos = Convert.ToInt32(valores[1]);
            int totalMin = (horas * 60) + minutos;
            return totalMin;
        }
    }
}
