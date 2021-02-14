using System;

namespace _15.Objetos
{
    public class Empleado
    {
        private string nombre;
        private int edad;

        //Constructor
        public Empleado(){

        }
        public Empleado(string nombre, int edad){
            this.nombre=nombre;
            this.edad=edad;
        }
        //propiedad; metodo publico para acceder a las variables
        public string Nombre{
            get {return nombre;} //salida
            set{nombre=value;}  //Entrada
        }

        public int Edad{
            get {return edad;}
            set {edad=value;}
        }



        //Metodo
        public void CalcularVacaciones(DateTime inicio, double dias){
                DateTime final;
                final=inicio.AddDays(dias);

                Console.WriteLine("Tienes vacaciones desde {0} hasta {1}",inicio.ToString("dd/MMM/yy"),final.ToString("dd/MMM/yy"));
        }

    }
}