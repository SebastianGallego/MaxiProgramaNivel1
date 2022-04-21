using System;

namespace Ejercicio7_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
        //    1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
        //        Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su 
        //        posición dentro del vector.


        int[] nros = new int[10];
        int maximo=0, pos=0;

        Console.WriteLine("Ingrese 10 nros Enteros: ");

        for (int i = 0; i < 10; i++)
        {
          nros[i] = int.Parse(Console.ReadLine());  

          if(nros[i]>maximo){
              maximo=nros[i];
              pos=i;
              }  
        }

    Console.WriteLine("El Maximo es: " + maximo + " en la posición : " + (pos+1));
    


        }// Fin del Main
    }
}
