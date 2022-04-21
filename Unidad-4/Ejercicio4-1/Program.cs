using System;

namespace Ejercicio4_1
{
    class Program
    {
        static void Main(string[] args)
        {
         /* 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

            La resta si el primero es mayor que el segundo.
            La suma si son iguales.
            El producto si el primero es menor.

            Se deberá emitir un cartel por pantalla con el resultado correspondiente.
          */
          
          int n1, n2;
          float result=0;  

        Console.Write("Ingrese N1: ");
            n1 = int.Parse(Console.ReadLine());   

        Console.Write("Ingrese N2: ");
            n2 = int.Parse(Console.ReadLine()); 

          
        if (n1 > n2) result = n1-n2;
        
        if (n1 < n2) result = n1*n2;

        if (n1 == n2)  result = n1+n2;
          
         Console.WriteLine("El menor es: " + result);
        }
    }
}
