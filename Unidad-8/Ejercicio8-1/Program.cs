using System;

namespace Ejercicio8_1
{
    class Program
    {
        static void Main(string[] args)
        {
          //  1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
          //    Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla 
          //    el monto total a pagar. Usar la función.

        int precio, cant, r;
        Console.Write("Precio: ");
        precio = int.Parse(Console.ReadLine()); 
        Console.Write("Cantidad: ");
        cant = int.Parse(Console.ReadLine());
        r = producto(precio,cant);
        Console.Write("El producto es: " + r);
        }//Fin del main
   
   
        static int producto(int n1, int n2)
        {
          int r;
          r=n1*n2;  
          return r;  
        }
    }
}
