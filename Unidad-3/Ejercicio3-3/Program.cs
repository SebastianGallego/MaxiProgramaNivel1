using System;

namespace Ejercicio3_3
{
    class Program
    {
        static void Main(string[] args)
        {
        // 3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
        //  Si el importe es menor a ARS 1000, no hay descuento.
        //  Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
        //  Si el importe es ARS 5000 o más, aplica un descuento del 18%.

        // Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.

        float compra, dto;

       Console.WriteLine("Ingrese el valor de la Compra: ");
       compra = float.Parse(Console.ReadLine());   

        if (compra >= 5000)
          dto=0.82F;
             
           else if (compra >= 1000)
             dto=0.9F;
              else 
               dto=1F;


        compra= compra * dto;       
        
        Console.WriteLine("El total es: $ " + compra);



        }
    }
}
