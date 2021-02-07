using System;
// programa que genera 2 vectores de 15 numeros aleatorios y la suma de un tercer vector
namespace _9vectoraleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM=15;
            int[] A= new int[TAM];
            int[] B= new int[TAM];
            int[] C= new int[TAM];
            Random rnd = new Random();

            for(int i=0; i<TAM; i++){
                A[i]=rnd.Next(1,100);
                B[i]=rnd.Next(1,100);
                C[i]=A[i]+B[i];
            }
            Console.Write("\n Elementos en el vector A: "); imprime(A);
            Console.Write("\n Elementos en el vector B: "); imprime(B);
            Console.Write("\n Elementos en el vector C: "); imprime(C);

            Console.WriteLine("programa que genera 2 vectores de 15 numeros aleatorios y la suma de un tercer vector!\n");
        }

        static void imprime(int[] v){
                for(int i=0; i<v.Length;i++){
                    Console.Write("{0} ",v[i]); 
                Console.WriteLine("\n\n"); 
                }
        }
    }
}
