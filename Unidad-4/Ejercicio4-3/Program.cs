using System;

namespace Ejercicio4_3
{
    class Program
    {
        static void Main(string[] args)
        {
          //  3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
          //     Para ello existe la siguiente escala de precios:
	      //                     i5 (1) 	i7 (2) 	i9 (3)
          //     8 RAM (1) 	    USD 800 	USD 900 	USD 1200
          //     16 RAM (2) 	USD 900 	USD 1000 	USD 1400
          //     32 RAM (3) 	USD 1000 	USD 1400 	USD 2000

          //  Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar 
          //  a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
          //  Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no 
          //  (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.

        int micro, ram, hd, total=0;

        Console.Write("Ingrese opcion MicroControlador: ");
            micro = int.Parse(Console.ReadLine());   

        Console.Write("Ingrese opcion de Memoria: ");
            ram = int.Parse(Console.ReadLine()); 
        
        Console.Write("Ingrese Ampliar HD marque 1: ");
            hd = int.Parse(Console.ReadLine()); 
        

        if (micro == 1){
            if (ram == 1)  total=800;
            if (ram == 2)  total=900;
            if (ram == 3)  total=1000;
            }

        if (micro == 2){
            if (ram == 1)  total=900;
            if (ram == 2)  total=1000;
            if (ram == 3)  total=1400;
            }

        if (micro == 3){
            if (ram == 1)  total=1200;
            if (ram == 2)  total=1400;
            if (ram == 3)  total=2000;
            }

        if (hd == 1) total += 300;

    Console.Write("Total a pagar: u$s " + total);

        }
    }
}
