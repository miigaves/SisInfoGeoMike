﻿using System;

namespace _3areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float labase, laaltura, laarea;
            Console.WriteLine("Calculando area de un triangulo\n!");
            Console.WriteLine("Dame la base\n!");
            labase=float.Parse(Console.ReadLine());
            Console.WriteLine("Dame la altura\n!");
            laaltura=float.Parse(Console.ReadLine());

            laarea=labase*laaltura/2;
            

            Console.WriteLine($"El area es {laarea}");
        }
    }
}
