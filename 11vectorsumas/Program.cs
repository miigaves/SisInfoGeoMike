using System;

namespace _11vectorsumas
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM=30;
           
            int[] A= new int[TAM];
            Random rnd = new Random();
            int positivo=0, negativo=0, cero=0;
            for(int i=0; i<TAM; i++){
                A[i]=rnd.Next(-50,50);
                           
            
            
                    if(A[i]>0){
                        positivo+=+1;
                    }
                    else{
                        if(A[i]<0){
                            negativo+=+1;
                        }
                    else{
                        cero+=+1;
                    }
                    }
                
                }
            
            Console.WriteLine("Numeros aleatorios son:  "); imprime(A);
                

            Console.WriteLine("\n Programa que almacena 30 numeros aleatorios e imprime cuantos son 0 cuantos[+] cuantos[-] y los suma.!\n");
            Console.WriteLine("\n Cuantos son 0[{0}] cuantos[+]=[{1}] cuantos[-]=[{2}]\n",cero,positivo,negativo);
        }
        
        static void imprime(int[] v){
                for(int i=0; i<v.Length;i++){
                    Console.Write("{0} ",v[i]); 
                }
        }
     
        }
    }

