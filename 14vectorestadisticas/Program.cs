using System;
namespace _14vectorestadisticas
{
    class Program
    {
       public static void Main(string[] args)
        {
            const int MAX=100;
            int n=0;
            
            double[] valores;
            double mayor=0, menor=0,promedio=0,varianza=0,desvest;
            Console.WriteLine("Programa que genera estadisticas de numeros!");
            
            Console.WriteLine("Cuantos elementos quieres calcular?"); n=int.Parse(Console.ReadLine());
            if(n>MAX){
                Console.WriteLine("El numero maximo de elementos es 100 tu ingresaste {0}\n ",n);
            }
            else {

            valores = new double[n];
            for(int i=0; i<n;i++){

                Console.Write("Valores [{0}]",i+1);
                valores[i]=double.Parse(Console.ReadLine());
            }
            //calculos
            mayor=funciones.May(valores);
            menor=funciones.Men(valores);
            menor=funciones.Prom(valores);
            varianza=funciones.Var(valores,promedio);
            desvest=Math.Sqrt(varianza);


            //salida
            Console.WriteLine("El mayor es: {0} ",mayor);
            Console.WriteLine("El menor es: {0} ",menor);
            Console.WriteLine("El promedio es: {0} ",promedio);
            Console.WriteLine("La varianza es: {0} ",varianza);
            Console.WriteLine("La desviacion estandar es: {0} ",desvest);
            }
        }
    
        
        }

}
