using System;

namespace Unidad_3
{
    class Program
    {
        static void Main(string[] args)
        {

        // 1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel 
        //    aclaratorio si “Es mayor a 10” o “No es mayor a 10”.   
           
        int nro;

        Console.WriteLine("Ingrese un Numero: ");
        
        nro = int.Parse(Console.ReadLine());

        if (nro > 10)
            Console.WriteLine("Nro Mayor a 10");
            else 
               Console.WriteLine("El Nro no es Mayor a 10");

        }
    }
}
