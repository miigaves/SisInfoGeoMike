using System;
using System.Collections.Generic;

public class Escuela{

    public Escuela(){ Profes= new List<Profesor>();}

    public Escuela(string nombre, string encargado, string domicilio) =>
    (nombre,encargado,domicilio)=(Nombre,Encargado,Domicilio);

    public string Nombre{get; set;}
    public string Encargado{get; set;}
    public string Domicilio{get; set;}
    public List<Profesor> Profes {get; set;}
    public List<Alumno> Alumnos {get; set;}

    public int MaySal(){
        int m=Profes[0].Salario;
        foreach(Profesor n in Profes)
            if(n.Salario>m)
            m=n.Salario;
        return m;
    }

    public int MenSal(){
        int m=Profes[0].Salario;
        foreach(Profesor n in Profes)
            if(n.Salario<m)
            m=n.Salario;
        return m;
    }

    public int TotAlum(){
        int s=0;
        foreach(Profesor n in Profes){
            s+=n.Alumnos.Count;
        }
        return s;
    }
     
     public int MayCal(){
        int m=Profes[0].Salario;
        foreach(Profesor n in Profes)
            if(n.Salario>m)
            m=n.Salario;
        return m;
    }
    /*public int MenCal(){
        int m=Alumnos[0].Calificaciones;
        foreach(Profesor n in Profes)
            if(n.Salario<m)
            m=n.Salario;
        return m;
    }*/
     public int Nobecado(){
        int m=Alumnos[0].Becado;
        foreach(Alumno n in Alumnos)
            if(n.Becado==0){
                m+=1;
            }
           
              
        return m;
    }
    public int Sibecado(){
        int m=Alumnos[0].Becado;
        foreach(Alumno n in Alumnos)
            if(n.Becado==1){
                m+=1;
            }
            
              
        return m;
    }
    
   
}