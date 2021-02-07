using System;
// programa que calcula el promedio de un vector de 50 valores constantes 
namespace _8vectorpromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vector = {10,15,20,25,30,35,40,45,50,55,
                            10,15,20,25,30,35,40,45,50,55,
                            10,15,20,25,30,35,40,45,50,55,
                            10,15,20,25,30,35,40,45,50,55,
                            10,15,20,25,30,35,40,45,50,55};

            int suma =0, nmp=0;
            float promedio=0;
            Console.WriteLine(" programa que calcula el promedio de un vector de 50 valores constantes ");
                //calcula suma de los arreglos 
                for(int i=0; i<vector.Length;i++){

                    Console.Write("{0} ",vector[i]);
                    suma+=vector[i];
                }
                //calcular promedio
                promedio= suma/vector.Length;
                //contar cuantos elementos de arreglo son los mayores al promedio
                Console.WriteLine("\n\n");
                Console.WriteLine("\nLa suma de los numeros del vector es : {0}",suma); 
                Console.WriteLine("\nEl promedio de los numeros del vector es : {0}\n\n",promedio); 
                for(int i=0; i<vector.Length;i++){
                    if(vector[i]>promedio){
                        Console.Write("{0} ",vector[i]);
                        nmp++;
                    }
                }
                Console.WriteLine("\n Los numeros mayores la promedio son {0}",nmp);

        }
    }
}
