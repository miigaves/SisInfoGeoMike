using System;

namespace _15.Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado01 = new Empleado();
            Empleado empleado2;

            empleado2=new Empleado();

            Empleado empleado3 = new Empleado("Maria",45);

            empleado01.Nombre="juan";
            empleado01.Edad=25;
            empleado2.Nombre="Pedro";
            empleado2.Edad=30;

            Console.WriteLine("Empleado 1: {0}, {1}",empleado01.Nombre,empleado01.Edad);
             empleado01.CalcularVacaciones(DateTime.Parse("09/02/2021"),10);
            Console.WriteLine("Empleado 2: {0}, {1}",empleado2.Nombre,empleado2.Edad);
             empleado2.CalcularVacaciones(DateTime.Parse("09/02/2021"),15);
            Console.WriteLine("Empleado 3: {0}, {1}",empleado3.Nombre,empleado3.Edad);
            empleado3.CalcularVacaciones(DateTime.Parse("09/02/2021"),5);

           
           
        
        }
    }
}