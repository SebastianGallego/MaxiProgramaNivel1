using System;

namespace Ejercicio4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
            // si la suma de los dos primeros es mayor al producto del segundo con el tercero.

        int n1, n2, n3;


        Console.Write("Ingrese lel Nro 1: ");
            n1 = int.Parse(Console.ReadLine());   

        Console.Write("Ingrese lel Nro 2: ");
            n2 = int.Parse(Console.ReadLine()); 

        Console.Write("Ingrese lel Nro 3: ");
            n3 = int.Parse(Console.ReadLine()); 

        if ((n1+n2)>(n2*n3)) 
              Console.Write(" SI N1+N2 > N2xN3 ");
              else
              Console.Write(" NO N1+N2 > N2xN3 ");

        }
    }
}
