using System;

namespace Ejercicio2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. 
            // Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            
              int sueldo=15000, venta=0 ;
              float total;
          

        Console.WriteLine("Ingrese el total facturado: $ ");
        venta = int.Parse(Console.ReadLine());
        

        total = sueldo + venta * 0.05F ;

        Console.WriteLine("Total a Cobrar: $ " + total);
        
        }
    }
}
