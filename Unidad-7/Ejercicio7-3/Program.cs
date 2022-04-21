using System;

namespace Ejercicio7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        // 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
        //    El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido 
        //    reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
           
        //     CADENA FUENTE: “La mar estaba serena"
        //     CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        //     CADENA RESULTADO: “Li mir estibi sereni"


        char[] cadena = new char[30];  //Cadena de caracteres o vector char
        char letra, lActual, lNueva;
        int i=0;

      Console.Write("Ingrese la letra a Reemplazar: ");
      lActual=char.Parse (Console.ReadLine());

      Console.Write("Ingrese la letra Reemplazo: ");
      lNueva =char.Parse (Console.ReadLine());

      Console.Write("Ingrese una letra: ");
      letra=char.Parse (Console.ReadLine());

      while(letra!='0' && i<30)
      {
          cadena[i]=letra;
          Console.Write("Ingrese Otra letra: ");
          letra=char.Parse (Console.ReadLine());
          i++;

      }
      cadena[i]= '\0';

      Console.Write("La cadena Original es: ");

      i=0;
      while(cadena[i]!='\0') 
      {
       Console.Write(cadena[i]);   
       i++;
      } 
      
      

      i=0;
      while(cadena[i]!='\0') 
      {
       if(cadena[i]==lActual) cadena[i]=lNueva;
       i++;
      } 

      Console.Write(" //  La cadena Final es: ");
       i=0;
      while(cadena[i]!='\0') 
      {
       Console.Write(cadena[i]);   
       i++;
      } 



        } //Fin del Main
    }
}
