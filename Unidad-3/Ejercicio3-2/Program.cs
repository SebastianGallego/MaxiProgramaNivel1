using System;

namespace Ejercicio3_2
{
    class Program
    {
        static void Main(string[] args)
        {
        // 2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla 
        //     “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero 
        //      o “Cero” si el número es igual a cero.   
           
        int nro;

        Console.WriteLine("Ingrese un Numero: ");
        
        nro = int.Parse(Console.ReadLine());   

        if (nro > 0)
            Console.WriteLine("Positivo");
            else if (nro == 0)
                 Console.WriteLine("Cero");
                 else 
                    Console.WriteLine("Negativo");


        }
    }
}
