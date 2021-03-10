using System;

namespace _26.Delegados5
{
    public delegate void MiDelegado(string msj);
    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d1,d2,d3;
            d1=A.MetodoA;
            d2=B.MetodoB;
            d3=(string msj) =>Console.WriteLine($"Llamando al metodo con expresion lambada: {msj}");
            d1("Hola Mundo");
            d2("Hola Mundo");
            d3("Hola Mundo");

            Invocar(d1);
            Invocar(d2);
            Invocar(d3);
            

        }

        static void Invocar (MiDelegado d){
            d("Llamando desde el Invocador");
        }

        public class A{
            public static void MetodoA(string msj)=>Console.WriteLine($"Llamando al metodo A de la clase A: {msj}");
        }

        public class B{
            public static void MetodoB(string msj)=>Console.WriteLine($"Llamando al metodo B de la clase B: {msj}");
        }
    }
}