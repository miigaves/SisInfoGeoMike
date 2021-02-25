using System;
using System.Collections.Generic;

public class Nodo{

    public Nodo(){Vulnerabilidades=new List<Vulnerabilidad>();}

    public Nodo(string ip, string tipo,int puertos,int saltos, string so)=>
        (ip,tipo,puertos,saltos,so)=(Ip,Tipo,Puertos,Saltos,So);
    
    
    public string Ip{get;set;}
    public string Tipo{get;set;}
    public int Puertos{get;set;}
    public int Saltos{get;set;}
    public string So{get;set;}
    public List<Vulnerabilidad> Vulnerabilidades{get; set;}

    public override string ToString() =>
        String.Format($"Ip:{Ip}, Tipo: {Tipo}, Puertos: {Puertos.ToString()},Saltos: {Saltos.ToString()}, SO: {So}, TotVul:{Vulnerabilidades.Count.ToString()}");


}