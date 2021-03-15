using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5AnalisisGuia9
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.Title = "Programa que informa cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $350";

        Double salario, empleadoentre100y300 = 0, empleadomayora300 = 0;

        Console.WriteLine("¿Cuántos empleados va a procesar? ");
        Double n = Double.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
        Console.WriteLine("Digite el salario del empleado " + (i + 1) + ":");
        Console.Write("$");
        salario = Double.Parse(Console.ReadLine());

        if (salario >= 100 && salario <= 300)
        {
        empleadoentre100y300 = empleadoentre100y300 + 1;
        }
        
        if (salario > 300)
        {
        empleadomayora300 = empleadomayora300 + 1;
        }
        }
         
        Console.WriteLine();
        Console.WriteLine("La cantidad de empleados que cobran entre $100 y $300 son: " + empleadoentre100y300 + ".");
        Console.WriteLine("La cantidad de empleados que cobran más de $300 son: " + empleadomayora300 + ".");


        Console.ReadKey();
        }
    }
}
