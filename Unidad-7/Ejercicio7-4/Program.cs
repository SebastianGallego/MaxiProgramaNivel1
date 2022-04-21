using System;

namespace Ejercicio7_4
{
    class Program
    {
        static void Main(string[] args)
        {
        
        //   4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
        //     - Número de Artículo (1 a 15)
        //     - Cantidad Vendida 

        //     Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
        //     Se pide determinar e informar:
        //     a) El número de artículo que más se vendió en total.
        //     b) Los números de artículos que no registraron ventas.
        //     c) Cuantas unidades se vendieron del número de artículo 10.      


        int[] ventas =new int[15];      //Vector de Ventas de cada articulo
        int nroArticulo, venta, max=0, indice=0;

        
        
        for (int i = 0; i < 15; i++)   //Inicializo en vector que acumula las ventas
        {
         ventas[i]=0;   
        }
        
        
        Console.Write("Ingrese el Nro de Articulo: ");
        nroArticulo=int.Parse (Console.ReadLine());

        while(nroArticulo!=0)
            {
             Console.Write("Ingrese la cantidad Vendida: ");
             venta=int.Parse (Console.ReadLine());    

             ventas[nroArticulo-1]+=venta;   

            Console.Write("Ingrese el Nro de Articulo: ");
            nroArticulo=int.Parse (Console.ReadLine());
            } //Termina el while


        // a) El número de artículo que más se vendió en total.
        Console.WriteLine(" ");
        for (int i = 0; i < 15; i++)   
        {
         if (ventas[i]>max)
           {
            max=ventas[i];
            indice=i;
           }
         }

         Console.WriteLine("a) El Articulo mas vendido: " + (indice+1)+ " Unidades: " + max);


        //     b) Los números de artículos que no registraron ventas.
        Console.WriteLine(" ");
        Console.WriteLine("b) Articulos que mo registraron ventas: ");
        for (int i = 0; i < 15; i++)   //muestro el vector ventas
        {
         if (ventas[i]==0) Console.Write(" | " + (i+1));
         }

        //     c) Cuantas unidades se vendieron del número de artículo 10.   
        Console.WriteLine(" ");
        Console.WriteLine("c) Unidades vendidas del Articulo 10: " + ventas[9]);
        
        
        Console.WriteLine(" ");
        Console.WriteLine("Vector Ventas: ");
        for (int i = 0; i < 15; i++)   //muestro el vector ventas
        {
         Console.Write(" | " + ventas[i]); 
         }




        }//Fin del main
    }
}
