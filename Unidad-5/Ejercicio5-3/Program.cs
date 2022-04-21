using System;

namespace Ejercicio5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad 
            //   de aquellas personas mayores a 18 años.


            int i, edad, contador=0, accu=0;

        for (i=0; i<10; ++i){
           Console.Write("Ingrese la Edad (" + (i + 1) + "): ");
            edad = int.Parse(Console.ReadLine());   

            if ( edad > 18) {
               contador ++;
               accu += edad;
             }    
         }
                
           Console.Write("Promedio de Edad : " + (accu/contador) );
        }
    }
}
