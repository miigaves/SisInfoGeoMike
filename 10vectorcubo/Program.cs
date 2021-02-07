using System;
//Programa que genera un vector aleatorio de 20 elementos lo eleva al cubo y guarda otro vector
namespace _10vectorcubo
{
    class Program
    {
        static void Main(string[] args)
        {
                const int TAM=20;
                double[] A= new double[TAM];
                double[] B= new double[TAM];
                Random rnd = new Random ();
            Console.WriteLine("Programa que genera un vector aleatorio de 20 elementos lo eleva al cubo y guarda otro vector!");

            for (int i=0; i<TAM; i++){
                A[i]= rnd.Next(-10,50);
                B[i]= Math.Pow(A[i],3);
                
            }
            Console.WriteLine("\n Elementos en el vector A:"); imprime(A);
            Console.WriteLine("\n Elementos en el vector B:"); imprime(B);
        }
        static void imprime(double[] v){
             for (int i=0;i<v.Length;i++)
                Console.Write("{0} ",v[i]); 
        }
    }
}
