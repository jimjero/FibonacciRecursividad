using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Estandar de codificación Camel Case

namespace FibonacciRecursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            //Leer el teclado
            Console.WriteLine("Ingrese el tamaño de la serie Fibonacci: ");

            //variable para guardar el numero digitado por teclado
            long numero = long.Parse(Console.ReadLine());

            //Dejar un espacio entre la cantidad digitada para la serie y el comienzo de la serie
            Console.WriteLine(" ");

            //Muestra el resultado y/o la serie
            for (int i = 0; i < numero; i++)
            {

                if (esPrimo(serieFibonacci(i)))
                {
                    Console.WriteLine(serieFibonacci(i) + " - " + "Número Primo");
                }
                else
                {
                    Console.WriteLine(serieFibonacci(i) + " - ");
                }
            }
            Console.ReadKey(true);
        }

        //Metodo que calcula la secuencia hasta llegar a N numeros
        public static long serieFibonacci(long numeroIngresado)
        {

            if (numeroIngresado > 1)
            {
                //Funcion Recursiva
                return serieFibonacci(numeroIngresado - 1) + serieFibonacci(numeroIngresado - 2);
            }
            else if (numeroIngresado == 1)
            {
                //Caso base
                return 1;
            }
            else if (numeroIngresado == 0)
            {
                //Caso base
                return 0;
            }
            else
            {
                //Error
                Console.WriteLine("Ingrese un tamaño igual o mayor a 1");
                return -1;
            }
        }

        //Metodo que define si el numero de la serie es primo o no
        public static Boolean esPrimo(long numeroValidar)
        {
            //Variable para guardar si el número a valir es primo o no
            Boolean validacionPrimo = false;
            //Variable contadora de cantidad de divisibles que tiene el número ingresado
            int cantidadDivisibles = 0;

            //for para saber cuantos numeros divisibles tiene el valor ingresado
            for (int i = 1; i <= numeroValidar; i++)
            {
                if (numeroValidar % i == 0)
                {
                    cantidadDivisibles++;
                }
            }

            //saber si el valor solo tiene 2 numeros divisibles/ primo
            if (cantidadDivisibles == 2)
            {
                validacionPrimo = true;
            }
            return validacionPrimo;
        } 
    }

}

