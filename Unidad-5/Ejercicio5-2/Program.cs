using System;

namespace Ejercicio5_2
{
    class Program
    {
         static void Main(string[] args)
        {
          // 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. 
          //    Solo se debe emitir UN valor por pantalla.
          
        int nro, i, mayor=0;

        for (i=0; i<10; ++i){
           Console.Write("Ingrese el Nro " + (i + 1) + ": ");
            nro = int.Parse(Console.ReadLine());   

            if ( nro > mayor) mayor=nro;
        } 
        
        Console.Write("El Nro Mayor es: " + mayor);
        }
    }
}
