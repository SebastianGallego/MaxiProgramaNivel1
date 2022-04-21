using System;

namespace Ejercicio6_3
{
    class Program
    {
        static void Main(string[] args)
        {
        //   3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
        //     El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.  
        //   
        //    
        //     Cargar un SubLote que corta con cero, y el Lote corta con un numero negativo   
        //     Son dos WHILE

        int nro, contador;

        Console.Write("Ingrese un Nro ");
        nro = int.Parse(Console.ReadLine());     
        
            while (nro > 0)
            {
                contador=0;
                while (nro !=0)
                {
                  contador++;      






              
                Console.Write("Ingrese Otro Nro ");
                nro = int.Parse(Console.ReadLine());
                }//Fin del While !=0 del SubLote


            Console.WriteLine("La lista tiene '" + contador + "' nros");

                         Console.Write("Ingrese Otro Nro ");
             nro = int.Parse(Console.ReadLine());
            } //Fin del While Negativo del Lote

        Console.WriteLine("Fin del Programa ");

        }//Final de MAIN
    }
}
