using System;

namespace Ejercicio5_4
{
    class Program
    {
        static void Main(string[] args)
        {
           // 4. Hacer un programa que solicite UN número y luego calcule y 
           //    emita un cartel aclaratorio si el mismo es primo o no es primo.  
           //    Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
            
        int nro, contador=0, i;

        Console.Write("Ingrese el nro : ");
            nro = int.Parse(Console.ReadLine());  

        
        for (i=1; i<=nro; ++i)
           {
             if (nro % i ==0)   contador++;
           }

        if (contador == 2) 
            Console.Write("El Número es Primo");
            else 
            Console.Write("El Número NO es Primo");
        
        }
    }
}
