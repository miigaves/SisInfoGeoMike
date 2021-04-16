using System;
using System.Collections.Generic;

public class Profesor{

    public Profesor(){Alumnos = new List<Alumno>();}

    public Profesor(string nombre, DateTime fechaing,string grupo,string materia,int salario) =>
        (nombre,fechaing,grupo,materia,salario)=(Nombre,Fechaing,Grupo,Materia,Salario);

    public string Nombre{get; set;}    
    public DateTime Fechaing{get; set;}    
    public string Grupo{get; set;}    
    public string Materia{get; set;}    
    public int Salario{get; set;}
    public List<Alumno> Alumnos {get; set;}
    public int Antiguedad() => DateTime.Now.Year-Fechaing.Year;

   
    public override string ToString() =>
        String.Format($"Nombre: {Nombre}, FechaIng: {Fechaing.ToString("dd/mm/yy")}, Grupo: {Grupo}, Materia: {Materia}, Salario: {Salario.ToString()}, Alumnos: {Alumnos.Count.ToString()} , Antiguedad:{Antiguedad().ToString()} ");
}