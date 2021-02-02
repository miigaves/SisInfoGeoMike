using System;

namespace _7tablas
{
    class Program
    {
        static int Main(string[] args)
        {
            int op, tabla, limsup,c,resultado,limtabla,i;
            if(args.Length==0){
                Menu();
                return 1;
            }
            Console.WriteLine("Tablas de multipicar.");
                    op=int.Parse(args[0]);
            switch(op){
                case 1: //Imprimir una tabla de multiplicar específica hasta cierto número
                    {   
                        Console.WriteLine("Que tabla quieres?");
                        
                            tabla= Int32.Parse(Console.ReadLine());
                            
                        Console.WriteLine("Hasta que numero quieres la tabla?");
                            limsup= Int32.Parse(Console.ReadLine());
                        for (c=1;c<=limsup;c++){

                            resultado=tabla*c;
                             Console.WriteLine("La tabla del {0} es: {1} * {0} = {2}",tabla,c,resultado);
                        }
                        
                   
                    }break;

                 case 2: //Imprimir las tablas deseadas hasta el número deseado
                        {   
                        Console.WriteLine("Hasta que tabla quieres que llegue?");
                        
                            limtabla= Int32.Parse(Console.ReadLine());
                        
                                               
                        Console.WriteLine("Hasta que numero quieres la tabla?");
                            limsup= Int32.Parse(Console.ReadLine());
                    for (i=1;i<=limtabla;i++){

                        int contador=i; 

                        for (c=1;c<=limsup;c++){

                            resultado=contador*c;
                             Console.WriteLine("La tabla del {0} es: {1} * {0} = {2}",contador,c,resultado);
                         }
                        }
                   
                    }break;

                   
        }
        return 0;
    }
    static void Menu(){
            Console.Clear();
            Console.WriteLine("[1] Imprimir una tabla de multiplicar específica hasta cierto número  ");
            Console.WriteLine("[2] Imprimir las tablas deseadas hasta el número deseado              ");
           
        }
    }
}
