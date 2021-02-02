using System;

namespace _6pizza
{
    class Program
    {
        static int Main(string[] args)
        {
                char tam,cub,don;
                string[] ings;
                string tamaño="",ingredientes="",Cubierta,Donde;

                if(args.Length==0){
                    Menu();
                    return 1;
                }
                //elegir size

                tam=char.Parse(args[0].ToUpper());
                if(tam=='P') tamaño="Pequeña";
                else if (tam=='M') tamaño="Mediana";
                else tamaño="Grande";

                //Elegir ingredientes
                ings=args[1].Split("+");
                foreach(string i in ings){
                    switch(char.Parse(i.ToUpper())) {
                        case 'E' : ingredientes+="ExtraQueso "; break;
                        case 'C' : ingredientes+="Champinones "; break;
                        case 'P' : ingredientes+="Pina "; break;
                        
                    }
                }
                //Tipo de cubierta
                cub=char.Parse(args[2].ToUpper());
                Cubierta= (cub=='D' ? "Delgada":"Gruesa");
                //Donde se la come
                don=char.Parse(args[3].ToUpper());
                Donde= (cub=='A' ? "Aqui":"Llevar");
                //Resultado del pedido
                Console.WriteLine("Tu pizza quedo asi:\n");
                Console.WriteLine("tamaño: {0}  ",tamaño);
                Console.WriteLine("Ingredientes: {0}  ",ingredientes);
                Console.WriteLine("Cubierta: {0}  ",Cubierta);
                Console.WriteLine("Donde: {0}  ",Donde);

                return 0;
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Elige como deseas armar tu pizza\n");
            Console.WriteLine("Size: [P]queña  [M]ediana  [G]rande");
            Console.WriteLine("Ingredientes : [E]xtra queso, [C]hamp, [P]ina, Unidos por un '+' ");
            Console.WriteLine("Cubierta: [D]elgada [G]ruesa ");
            Console.WriteLine("Donde te la comes: [A]qui [L]levar");



        }
    }
}
