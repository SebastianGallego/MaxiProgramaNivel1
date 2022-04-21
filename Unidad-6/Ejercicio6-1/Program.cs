using System;

namespace Ejercicio6_1
{
    class Program
    {
        static void Main(string[] args)
        {
           //1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla 
           //    cuántos de esos números son primos.

        int nro, cantPrimos=0, contador=0;    

         for (int i=1; i<=10; ++i){
           Console.Write("Ingrese el Nro " + i + ": ");
            nro = int.Parse(Console.ReadLine());   
            
            contador=0;
            for (int j=1; j<=nro; ++j)
               {
                if (nro % j == 0)   contador++;
               }
             
             if (contador == 2) cantPrimos++; 
         } 
        
        Console.Write("Cantidad de Primos: " + cantPrimos );

        }
    }
}
