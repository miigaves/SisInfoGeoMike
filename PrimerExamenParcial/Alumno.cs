using System;
using System.Collections.Generic;

public class Alumno{

    public Alumno(){ Calificaciones = new  int [3];}

    public Alumno(string nombre, int edad, DateTime fechaing, int becado , int [] calificaciones)=>
        (nombre, edad, fechaing,becado,calificaciones)=(Nombre,Edad,Fechaing,Becado,Calificaciones);

    public string Nombre{get; set;}
    public int Edad{get; set;}
    public DateTime Fechaing{get; set;}
    public int Becado{get; set;}

    public int [] Calificaciones{get; set;}

  

    public int Antiguedad() => DateTime.Now.Year-Fechaing.Year;

    public int Prom(int[] v){
        int n=0;
        int valor =0;
        for(int i=0;i<v.Length;i++){
            n+=v[i];
            
        }
       
        valor = n/v.Length;

        if(valor>6){
            Console.WriteLine("Aprobaste");
        }
        else{
            Console.WriteLine("Resprobaste");
        }


        return valor;
        }
  
        
      


    public override string ToString() =>

        String.Format($"Nombre: {Nombre}, Edad: {Edad}, Fechaing{Fechaing.ToString("dd/mm/yy")}, Becado: {Becado}, Califs:{Calificaciones + string.Join(",",Calificaciones)} ,Antiguedad: {Antiguedad().ToString()}, Prom:{Prom(Calificaciones)} ,Mensaje:{Prom(Calificaciones)}");
    
}