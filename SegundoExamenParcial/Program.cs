using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using Newtonsoft.Json;

Escuela miescuela =null;
string ruta = Path.Combine(Environment.CurrentDirectory,"datosescuela");

Inicializa(ref miescuela);
Reporte(miescuela);
jsonSerializa(miescuela);

repProfes(miescuela);

void repProfes(Escuela Profes){
    WriteLine("Reporte de la escuela \n");
    WriteLine("Reporte de la maestros \n");
    var npd = (Profes.Alumnos.Where(e=>e.Edad>20)).ToList();
    npd.ForEach(e=>WriteLine(e.ToString())); 

}
void xmlSerializa(Escuela escuela){
    WriteLine("\nSerializando datos en formato xml...");
    Utilerias.xmlGraba(ruta,escuela);

    Escuela otraescuela = new Escuela();
    WriteLine("\n Cargando datos del archivo {0}",ruta);
    Utilerias.xmlLeer(ruta,ref otraescuela);
    Reporte(otraescuela);
}
void jsonSerializa(Escuela escuela){
    WriteLine("\nSerializando datos en formato json...");
    Utilerias.jsonGraba(ruta,escuela);

    Escuela otraescuela = new Escuela();
    WriteLine("\nCargando datos del archivo {0}",ruta);
    Utilerias.jsonLeer(ruta,ref otraescuela);
    Reporte(otraescuela);
}
void Inicializa(ref Escuela e){
    e= new Escuela(){Nombre="Universidad Patito SA de CV", Encargado="Ing. Juan Perez",Domicilio="Av. De la Juventud 348"};

    //Agregar profesores a la escuela

    e.Profes.Add(new Profesor{Nombre="Jose Diaz", Fechaing=DateTime.Parse("01/01/2018"),Grupo="1A",Materia="Fisica",Salario=1200});
    e.Profes.Add(new Profesor{Nombre="Maria Perez", Fechaing=DateTime.Parse("10/02/2016"),Grupo="2A",Materia="Algebra",Salario=3400});
    e.Profes.Add(new Profesor{Nombre="Claudia Sid", Fechaing=DateTime.Parse("01/04/2019"),Grupo="4B",Materia="Calculo",Salario=3800});
    e.Profes.Add(new Profesor{Nombre="Carlos Lopez", Fechaing=DateTime.Parse("10/03/2016"),Grupo="8A",Materia="Quimica",Salario=1000});

    //Agregar Alumnos a profesores
    e.Profes[0].Alumnos.Add(
        new Alumno{
            Nombre="Uriel Gato", 
            Edad=23, 
            Fechaing=DateTime.Parse("01/01/2018"),
            Becado=0,
            Calificaciones = new int[] {7,7,7}});
     e.Profes[0].Alumnos.Add(
        new Alumno{
            Nombre="Rodriguez Díaz", 
            Edad=25, 
            Fechaing=DateTime.Parse("01/02/2016"),
            Becado=1,
            Calificaciones = new int[] {8,8,8}});
     e.Profes[0].Alumnos.Add(
        new Alumno{
            Nombre="Marco Aurelio", 
            Edad=23, 
            Fechaing=DateTime.Parse("13/01/2018"),
            Becado=0,
            Calificaciones = new int[] {6,6,6}});
    
     e.Profes[1].Alumnos.Add(
        new Alumno{
            Nombre="Guillermo Ochoa", 
            Edad=20, 
            Fechaing=DateTime.Parse("23/10/2018"),
            Becado=1,
            Calificaciones = new int[] {9,9,9}});
    e.Profes[1].Alumnos.Add(
        new Alumno{
            Nombre="Francisco Ordaz Díaz", 
            Edad=23, 
            Fechaing=DateTime.Parse("14/10/2018"),
            Becado=0,
            Calificaciones = new int[] {8,8,8}});

    e.Profes[3].Alumnos.Add(
        new Alumno{
            Nombre="Pepe Cuevas", 
            Edad=19, 
            Fechaing=DateTime.Parse("01/12/2016"),
            Becado=1,
            Calificaciones = new int[] {6,6,6}});
}

void Reporte(Escuela e){
    Console.WriteLine(">> Datos Generales de la Escuela:\n");
    Console.WriteLine($"Nombre: {e.Nombre}");
    Console.WriteLine($"Encargado: {e.Encargado}");
    Console.WriteLine($"Domicilio: {e.Domicilio}");

     Console.WriteLine($"\nTotal Profesores: {e.Profes.Count}");
     Console.WriteLine($"Total alumnos: {e.TotAlum()}");

    Console.WriteLine("\n>>Datos Generales de los Profesores:\n");
    e.Profes.ForEach(n=>Console.WriteLine(n.ToString()));
    Console.WriteLine($"\nMayor Salario: {e.MaySal()}");
    Console.WriteLine($"Menor Salario: {e.MenSal()}");

    Console.WriteLine($"Estan becados: {e.Sibecado()}");
    Console.WriteLine($"No estan becados: {e.Nobecado()}");

    Console.WriteLine("\n>> Alumnos por Profesor:\n");
    foreach(Profesor n in e.Profes){
        Console.WriteLine($"\n >Nombre: {n.Nombre}, Grupo: {n.Grupo}");
       
        n.Alumnos.ForEach(v=>Console.WriteLine(v.ToString()));
    }
   

}