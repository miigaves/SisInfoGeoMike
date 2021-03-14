using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = new string[]
            {"Pera", "Melon","Sandia","Durazno","Manzana","Platano","Kiwi","Naranja","Jicama","Piña"};
            
            WriteLine("\nFrutas que inician con la letra m");
            var mfrutas = from f in frutas where f.StartsWith('m') select f;
            foreach(string f in mfrutas) Write($"{f} ");

            var anfrutas = from f in frutas where f.Contains("an") select f;
            WriteLine("\nFrutas que contienen las letras an: {0}",anfrutas.Count());
            foreach(string f in anfrutas) Write($"{f}  ");

            var frutasa = (from f in frutas where f.EndsWith('a') select f).ToList();
            WriteLine("\nFrutas que terminan con la letra a: {0}",frutasa.Count());
            frutasa.ForEach(f=>Write($"{f} "));
        }
    }
}