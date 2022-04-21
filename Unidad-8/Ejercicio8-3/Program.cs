using System;

namespace Unidad_8
{
    class Program
    {
        static void Main(string[] args, Console console)
        {

        // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
        //    Hacer un programa para ingresar números. 
        //    El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.  
           
        int nro, accu=0, esPrimo, cantPrimos=0;

        Console.WriteLine("Ingrese un Numero: ");
        nro = int.Parse(Console.ReadLine());

        while(nro !=0)
        {

        esPrimo = primo(nro);

        if (esPrimo==1)
           {
           cantPrimos++;
           accu +=nro;
            }


        Console.WriteLine("Ingrese otro Nro: ");
        nro = int.Parse(console.ReadLine());
        }//Fin de While con 0    


        Console.WriteLine("La cantidad de Primos es: " + cantPrimos);
        Console.WriteLine("El promedio de Primos es: " + (accu / cantPrimos));



        }//Fin del Main


        static int primo(int nro)
        {
            int contador=0;

            for (int i=1; i<=nro; ++i)
                {
                 if (nro % i ==0)   contador++;
                }

          if (contador == 2) 
            return 1;
            else 
            return 0;

        }//Fin de la Funcion




    }
}
