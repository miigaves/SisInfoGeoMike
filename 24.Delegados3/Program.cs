﻿using System;

namespace _24.Delegados3
{   
    public delegate int MiDelegado(int a , int b);
    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d1=A.Suma;
            MiDelegado d2 =B.Multiplica;
            Console.WriteLine($"La suma es: {d1(10,20)}");
            Console.WriteLine($"La multiplicacion es: {d2(10,20)}");

            MiDelegado d = d1+d2;
            Console.WriteLine($"El resultado es: {d(10,20)}");
        }
    }

    public class A{
        public static int Suma(int a, int b) => a+b;
    }
    public class B{
        public static int Multiplica(int a, int b) =>a*b;
    }
}