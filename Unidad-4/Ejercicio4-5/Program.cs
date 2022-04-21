using System;

namespace Ejercicio4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla 
            //   si los mismos se encuentran ordenados de forma decreciente . 

        int n1, n2, n3, n4;


        Console.Write("Ingrese lel Nro 1: ");
            n1 = int.Parse(Console.ReadLine());   

        Console.Write("Ingrese lel Nro 2: ");
            n2 = int.Parse(Console.ReadLine()); 

        Console.Write("Ingrese lel Nro 3: ");
            n3 = int.Parse(Console.ReadLine()); 

        Console.Write("Ingrese lel Nro 4: ");
            n4 = int.Parse(Console.ReadLine()); 


        if (n4>n3 && n3>n2 && n2>n1)  
                   Console.Write("Los nros estan ordenados de MAYOR a menor ");
                   else
                   Console.Write("Los nros NO estan estan ordenados de MAYOR a menor ");
                   
              



        }
    }
}
