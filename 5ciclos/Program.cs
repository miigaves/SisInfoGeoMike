using System;

namespace ciclos
{
    class Program
    {
        static int Main(string[] args)
        {
            int op, suma, c;
            if(args.Length==0){
                Menu();
                return 1;
            }
            op=int.Parse(args[0]);
            switch(op){
                case 1: //Números del 1 al 100 con ciclo while
                    {   
                        c=1; suma=0;
                            while(c<=100){
                            Console.Write(" {0} ",c);
                            suma+=c;
                            c++;
                            }
                    Console.WriteLine("La suma es {0}",suma);
                    }break;

                 case 2: //Números del 100 al 1 con ciclo do .. while

                    {   
                        c=100; suma=0;
                        do{Console.Write(" {0} ",c);
                            suma+=c;
                            c--;}while(c>=1);
                            
                    Console.WriteLine("La suma es {0}",suma);
                    }break;

                case 3: //Números del 50 al 200 con ciclo for
                    {   
                        suma=0;
                        for(c=50;c<=200;c++);
                            Console.WriteLine("{0} ",c);
                    Console.WriteLine("La suma es {0}",suma);
                    }break;
                case 4: //Números del 2 al 100 solo los pares con ciclo for
                    {   
                        suma=0;
                        for(c=2;c<=100;c+=2);
                            Console.WriteLine("{0} ",c);
                    Console.WriteLine("La suma es {0}",suma);
                    }break;
                case 5: //Números del 99 al 1 solo los impares con ciclo for

                    {   
                        suma=0;
                        for(c=99;c>=1;c-=2);
                            Console.WriteLine("{0} ",c);
                    Console.WriteLine("La suma es {0}",suma);
                    }break;

                case 6: //Números del 272 al 40 en decrementos de 4 con ciclo while
                    {   
                        c=272; suma=0;
                        do{Console.Write(" {0} ",c);
                            suma+=c;
                            c-=4;}
                        while(c>=4);
                            
                    Console.WriteLine("La suma es {0}",suma);
                    }break;
                 default: Console.WriteLine("Opcion invalida");
                    break;
                
            }
            return 0;
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("[1] Numeros del 1 al 100 con ciclo while");
            Console.WriteLine("[2] Numeros del 100 al 1 con ciclo  do while");
            Console.WriteLine("[3] Numeros del 50 al 200 con ciclo for");
            Console.WriteLine("[4] Numeros del 2 al 100 con ciclo for en pares");
            Console.WriteLine("[5] Numeros del 99 al 1 con ciclo for en impares");
            Console.WriteLine("[6] Numeros del 272 al 40 en decrementos de 4 con ciclo while");
        }
    }
}
