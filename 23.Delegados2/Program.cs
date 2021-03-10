using System;

//Multicast

namespace _23.Delegados2
{
    public delegate void MiDelegado(string msj);
    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d1,d2,d3,d;

            d1 = Mensaje.Mensaje1;
            d2 =Mensaje.Mensaje2;
            d3 = (string msj) => Console.WriteLine($"{msj} Paga todo, que no pare la fiesta");
            d = d1 + d2 ;
            d("El peje");
            d+=d3;
            d("El rulas");
            d -=d2;
            d("Peña");
            d -=d1;
            d("Tello");

        }

        public class Mensaje{
            public static void Mensaje1(string msj) => Console.WriteLine($"{msj} - Lleva el pastel");
            public static void Mensaje2(string msj) => Console.WriteLine($"{msj} - Fue el culpable se cancela la fiesta");
        }
    }
}