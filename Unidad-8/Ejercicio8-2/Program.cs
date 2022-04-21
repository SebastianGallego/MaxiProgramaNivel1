

namespace Ejercicio8_2
{
    
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
          //  2. Hacer una función llamada “par” que reciba un número entero 
          //     y devuelva 1 si es par o cero si no lo es. 
          //     Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

        int  cantPares=0, nro;

        Console.Write("Ingrese 20 Numeros: ");
        
        for (int i = 0; i < 20; i++)
        {
           nro = int.Parse(Console.ReadLine());
           nro = par(nro);        
           if (nro==1) cantPares++;
        }
       
        Console.Write("La cantidad de Pares es: " + cantPares);

       }//Fin del main
   
   
        static int par(int n)
        {
            if(n % 2 == 0 )    
                return 1;
            else 
                return 0;  

        }
   
   
    }
}
