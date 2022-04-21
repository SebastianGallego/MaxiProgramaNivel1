using System;

namespace Ejercicio3_5
{
    class Program
    {
        static void Main(string[] args)
        {
          //5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
          
         float n1, n2,n3,n4;

       Console.Write("Ingrese N1: ");
       n1 = float.Parse(Console.ReadLine());   

       Console.Write("Ingrese N2: ");
       n2 = float.Parse(Console.ReadLine()); 

       Console.Write("Ingrese N3: ");
       n3 = float.Parse(Console.ReadLine()); 

       Console.Write("Ingrese N4: ");
       n4 = float.Parse(Console.ReadLine()); 

       if (n1>100)  Console.WriteLine("El numero " + n1 + " es mayor a 100");
          
       if (n2>100)  Console.WriteLine("El numero " + n2 + " es mayor a 100");

       if (n3>100)  Console.WriteLine("El numero " + n3 + " es mayor a 100");

       if (n4>100)  Console.WriteLine("El numero " + n4 + " es mayor a 100");   
          
          
        }
    }
}
