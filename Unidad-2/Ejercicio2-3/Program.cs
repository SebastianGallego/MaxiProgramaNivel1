using System;

namespace Ejercicio2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int km, vel, r ;
          

        Console.WriteLine("Ingrese los Km: ");
        km = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese Vel. Promedio: ");
        vel = int.Parse(Console.ReadLine());

        r = km/vel;
           
        Console.WriteLine("El tiempo aproximado son " + r + " horas");
        }
    }
}
