using System;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.IO;
using static System.Console;
using System.Linq;
public static class Utilerias{
    public static void xmlGraba(string ruta, Escuela escuela ){
        FileStream fs = File.Open(ruta+".xml",FileMode.Create);
        XmlSerializer xml = new XmlSerializer(typeof(Escuela));
        xml.Serialize(fs,escuela);
        fs.Close();
    }
    public static void xmlLeer(string ruta,ref Escuela escuela){
        FileStream fs = File.Open(ruta+".xml",FileMode.Open);
        XmlSerializer xml = new XmlSerializer(typeof(Escuela));
        escuela=(Escuela)xml.Deserialize(fs);
        fs.Close();
    }

    public static void jsonGraba(string ruta, Escuela escuela ){
        StreamWriter fs=File.CreateText(ruta+".json");
        JsonSerializer json = new JsonSerializer ();
        json.Serialize(fs,escuela);
        fs.Close();
    }
    public static void jsonLeer(string ruta,ref Escuela escuela){
        StreamReader fs=File.OpenText(ruta+".json");
        string strData = fs.ReadToEnd();
        escuela = JsonConvert.DeserializeObject<Escuela>(strData);
        fs.Close();


    }

    public static void reporteProfes(Escuela escuela){
    //Reporte (mi escuela)
    //reporteProfes(miescuela);
    WriteLine("Profesores con salario  >=3000");
    var Sa = (escuela.Profes.Where(n=>n.Salario >= 3000)).ToList();
    Sa.ForEach(n=>WriteLine(n.ToString()));
     WriteLine("Profesores con fecha de ingreso  >=2016");
    var FI = (escuela.Profes.Where(n=>n.Fechaing.Year>=2016)).ToList();
    FI.ForEach(nameof=>WriteLine(nameof.ToString()));
}

public static void ReportEstudiante(Escuela escuela){
    //ReportEstudiante(miescuela);
    WriteLine("Alumnos menores 20 años");
    var edad = (escuela.Alumnos.Where(n=>n.Edad<20)).ToList();
    edad.ForEach(n=>WriteLine(n.ToString("D2",System.Globalization.CultureInfo.CurrentCulture)));
    WriteLine("Alumnos con promedio menor a 8");
    var prom = (escuela.Alumnos.Where(n=>n.Calificaciones.Average()<8)).ToList();
    prom.ForEach(n=>WriteLine(n.ToString("D1",System.Globalization.CultureInfo.CurrentCulture)));
    
}


}