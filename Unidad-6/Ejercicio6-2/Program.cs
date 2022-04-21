using System;

namespace Ejercicio6_2
{
    class Program
    {
        static void Main(string[] args)
        {
        //     2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
        //       Se pide determinar e informar:
        //       - El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        //          (sacar el mayor de cada grupo)
        
        //       - Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
        //           (ver si el grupo está ordenado de mayor a menor y contarlos)   

        
        //    FOR de 5 vueltas con un WHILE que corta con cero cada Sub-Lote


        int nro, contador, porImpar, contImpar, grupoImpar=0, maxImpar=0, minimo, contOrdenado=0;
        bool ordenado=true;
        
        for (int i = 0; i < 5; i++)
        {
         Console.WriteLine("Grupo " + (i+1));
         Console.Write("Ingrese un Nro ");
         nro = int.Parse(Console.ReadLine());     
        
         contador=0;        //Inicializo los contadores en cada vuelta del FOR
         contImpar=0;
         minimo=nro;       //Por defecto el 1er valor es el minimo 
         ordenado = true; 

        while (nro !=0)
            {
            contador++;                         // Cuento para saber cuantos nros hay en el grupo
            if(nro % 2 != 0)   contImpar++;     //Impar >> si lo divido por 2 el resto no es cero
            
            if (nro <= minimo)      //si el nro ingresado es menor que el minimo guardado el nuevo minimo
                minimo = nro;  
                else
                ordenado=false;    // ya no está ordenado    
            
              
            Console.Write("Ingrese Otro Nro ");
            nro = int.Parse(Console.ReadLine());
            }//Fin del While

        porImpar=(contImpar*100)/contador;           
        Console.WriteLine("Porcentade de Impares: % " + porImpar);   

        if (porImpar > maxImpar){
            maxImpar=porImpar;
            grupoImpar=(i+1);
            }
        
        if(ordenado) {
                    contOrdenado++;  
                    Console.WriteLine("Ordenado");
                    } else Console.WriteLine("DesOrdenado");

        }//Fin del FOR

        Console.WriteLine("Grupo con Mayor % de Impares: " + grupoImpar);  //Grupo con Mayor % de Impares 
        Console.WriteLine("Cantidad de Grupos Ordenados de MAYOR a menor: " + contOrdenado);  //Cuantos Grupos estan ordenados

        }//Fin del Main
    }
}
