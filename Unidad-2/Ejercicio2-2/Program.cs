using System;

namespace Ejercicio2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r;


        Console.WriteLine("Ingrese un numero:");
        n = int.Parse(Console.ReadLine());
        
        r = n * n * n;
           
        Console.WriteLine("El resultado " + n + " al cubo: " + r);
        }
    }
}
