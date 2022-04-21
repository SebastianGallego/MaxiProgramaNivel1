using System;

namespace Ejercicio7_2
{
    class Program
    {
        static void Main(string[] args)
        {
        // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
        //   Luego recorrer ese vector para calcular el promedio. 
        //   Mostrar por pantalla los valores que son mayores al promedio.


        int[] nros = new int[10];
        int accu=0;

        Console.WriteLine("Ingrese 10 nros Enteros: ");

        for (int i = 0; i < 10; i++)
        {
          nros[i] = int.Parse(Console.ReadLine());  
                 
        }

        for (int i = 0; i < 10; i++)
        {
          accu +=nros[i];  
         }

        Console.WriteLine("El promedio es : " + (accu/10));


        }//Fin del Main
    }
}
