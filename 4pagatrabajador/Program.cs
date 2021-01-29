//Paga del trabajador
using System;

namespace _4pagatrabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;
            string nombre;
            float paga, tasa=0.10F;
            float impuesto, pagabruta, paganeta;
            Console.WriteLine("Calculo de paga de un trabajador!"); 
            Console.Write("Nombre de el trabajador: "); 
                nombre=Console.ReadLine(); 
            Console.Write("Horas trabajadas:        "); 
                horas=int.Parse(Console.ReadLine()); 
            Console.Write("Paga de el trabajador  : ");            
                paga= float.Parse(Console.ReadLine());

            pagabruta=horas * paga;
            impuesto = pagabruta * tasa;
            paganeta = pagabruta - impuesto;

            Console.WriteLine("Estimado : "+ nombre);
            Console.WriteLine($"Trabajaste {horas} con una paga de {paga}: ");
            Console.WriteLine("Paga bruta : {0}",pagabruta);
            Console.WriteLine("Paga impuestos : {0}",impuesto);
            Console.WriteLine("Paga neta : {0}",paganeta);

          
    }
}
