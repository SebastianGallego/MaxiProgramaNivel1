using System;

namespace Ejercicio2_5
{
    class Program
    {
        static void Main(string[] args)
        {
          // 5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.
           
           double promedio, n1, n2,n3;

           Console.WriteLine("Ingrese Nota 1: ");
            n1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese Nota 2: ");
            n2 = int.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese Nota 3: ");
            n3 = int.Parse(Console.ReadLine());

             promedio=(n1+n2+n3)/3;         

            Console.WriteLine("Nota Promedio: " + promedio.ToString("0.00"));
            
        }
    }
}
