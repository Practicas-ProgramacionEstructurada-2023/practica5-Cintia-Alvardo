using System;
using System.ComponentModel;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n ********CALCULADORA DE PROMEDIO UNIVERSITARIO********\n");

            //Solititando al estuadiante que ingrese las notas del primer computo
            Console.WriteLine("----------------------------------------------------- ");
            Console.WriteLine("Ingreses las notas del primer computo \n");
            Console.WriteLine("Ingreses la nota del Laboratorio 1: ");
            double Lab1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIngreses la nota del Parcial 1: \n");
            double Par1 = Convert.ToDouble(Console.ReadLine());

            //Solititando al estuadiante que ingrese las notas del segundo computo
            Console.WriteLine("\n----------------------------------------------------- ");
            Console.WriteLine("Ingreses las notas del segundo computo \n");
            Console.WriteLine("Ingreses la nota del Laboratorio 2: ");
            double Lab2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIngreses la nota del Parcial 2: \n");
            double Par2 = Convert.ToDouble(Console.ReadLine());

            //Solititando al estuadiante que ingrese las notas del tercer computo
            Console.WriteLine("\n----------------------------------------------------- ");
            Console.WriteLine("Ingreses las notas del tercer computo \n");
            Console.WriteLine("Ingreses la nota del Laboratorio 3: ");
            double Lab3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIngreses la nota del Parcial 3: \n");
            double Par3 = Convert.ToDouble(Console.ReadLine());

            //Calcular el promedio
            double promedioLab = (Lab1 + Lab2 + Lab3) * 0.60;
            double promedioPar = (Par1 + Par2 + Par3) * 0.40;
            double notaFinal = (promedioLab / 3) + (promedioPar / 3);

            Console.WriteLine("----------------------------------------------------- ");
            Console.WriteLine("\nSu nota final fue de: " + Math.Round(notaFinal, 1) + "\n");

            //comparar el promedio de las nota final


            //Comparar el promedio de las nota final

            if (notaFinal >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Usted paso la materia con una nota excelente :)\n");
                Console.ResetColor();
            }

            else if (notaFinal >= 6)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Usted paso la materia con una nota baja :|\n");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Usted saco una nota menor que 6, reprobo la mateia :(\n");
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}


