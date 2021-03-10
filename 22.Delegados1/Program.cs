using System;

namespace _22.Delegados1{

public delegate void MiDelegado(string msj);  //Creacion del delegado
class program{
    public static void Main(){
        MiDelegado d; //Instancia del delegado
        d=Mensaje.Mensaje1; //APuntar el delegado a un metodo  o funcion
        d("Juan");
        d=Mensaje.Mensaje2;
        d("Jose");

        d= (string msj) => Console.WriteLine($"{msj} - Paga todo , que no pare la fiesta");
        d("Carlos");
    }

}
    public class Mensaje{
        public static void Mensaje1(string msj) => Console.WriteLine($"{msj} - Lleva el pastel");
        public static void Mensaje2(string msj) => Console.WriteLine($"{msj} - Fue el culpable se cancela la fiesta");
    }
}