using System;
using System.Collections.Generic;

public class Red{
    //constructor
    public Red(){Nodos = new List<Nodo>();}

    public Red(string empresa, string propietario, string domiclio) =>
      (Empresa,Propietario,Domicilio)=(empresa,propietario,domiclio);

    public string Empresa{get; set;}
    public string Propietario{get; set;}
    public string Domicilio{get; set;}
    public List<Nodo> Nodos{get; set;}

    public int MaySal() {
      int m=Nodos[0].Saltos;
      foreach(Nodo n in Nodos)
        if(n.Saltos>m)
            m=n.Saltos;
      
      return m;
    }

    public int MenSal() {
      int m=Nodos[0].Saltos;
      foreach(Nodo n in Nodos)
        if(n.Saltos<m)
            m=n.Saltos;
      
      return m;
    }

    public int TotVul(){
      int s=0;
      foreach(Nodo n in Nodos)
        s+=n.Vulnerabilidades.Count;
      
      return s;
    }
    
}