using System;

namespace Ejercicio5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla 
            //    el máximo de los números pares y el mínimo de los números impares.


        int i, nro, maxPar=0, minImpar=0, contPar=0, contImpar=0;

        for (i=0; i<10; ++i){
           Console.Write("Ingrese un Nro (" + (i + 1) + "): ");
            nro = int.Parse(Console.ReadLine());   

            if ( nro % 2 == 0) {     //si divido por 2 y el resto es cero es porque es PAR
               
               if (contPar == 0 ) {    //Si es el primer Par, inicializo el Maximo con el primer valor
                   maxPar=nro;
                  }
                  else{ 
                      if (nro > maxPar) maxPar=nro;
                      }
            contPar++;

             }else{                  // si no, es Impar
                   
                   if (contImpar == 0 ) {    //Si es el primer imPar, inicializo el Minimo con el primer valor
                    minImpar = nro;
                  }
                  else{ 
                      if (nro < minImpar) minImpar=nro;
                      }
                    contImpar++;                    
               }   
                    
         }
                
           Console.WriteLine("Máximo de los Pares : " + maxPar);
           Console.WriteLine("Mínimo de los imPares : " + minImpar);
        }




        
    }
}
