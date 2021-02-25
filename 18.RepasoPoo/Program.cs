using System;
using System.Collections.Generic;

    Red mired=null;
    
    Inicializa(ref mired);
    Reporte(mired);

    void Inicializa(ref Red r){
        r = new Red(){Empresa="Red Patito",Propietario="Mr. Pato",Domicilio="Av. Guerrero 123, Zacatecas"};
        //Se agregan nodos a la red
        r.Nodos.Add(new Nodo{Ip="192.168.0.10",Tipo="Servidor",Puertos=5,Saltos=10,So="Linux"});
        r.Nodos.Add(new Nodo{Ip="192.168.0.12",Tipo="Equipo activo",Puertos=2,Saltos=12,So="ios"});
        r.Nodos.Add(new Nodo{Ip="192.168.0.20",Tipo="Computadora",Puertos=8,Saltos=5,So="Windows"});
        r.Nodos.Add(new Nodo{Ip="192.168.0.15",Tipo="Servidor",Puertos=10,Saltos=22,So="Linux"});

        //Agregar Vulnerabilidades a los nodos
        r.Nodos[0].Vulnerabilidades.Add(
            new Vulnerabilidad{
                Clave=" CVE-2015-1635", Vendedor= "microsoft", 
                Descripcion= "HTTP.sys permite a atacantes remotos ejecutar código arbitrario" , 
                Tipo= "remota", Fecha=DateTime.Parse(" 14/04/2015")});
        r.Nodos[0].Vulnerabilidades.Add(
            new Vulnerabilidad{
                Clave=" CVE-2017-0004", Vendedor= "microsoft", 
                Descripcion= "El servicio LSASS permite causar una denegación de servicio" , 
                Tipo= "local", Fecha=DateTime.Parse("01/10/2011")});

        r.Nodos[1].Vulnerabilidades.Add(
            new Vulnerabilidad{
                Clave="CVE-2017-3847", Vendedor= "cisco", 
                Descripcion= "Cisco Firepower Management Center XSS" , 
                Tipo= "remota", Fecha=DateTime.Parse("21/02/2017")});

        r.Nodos[2].Vulnerabilidades.Add(
            new Vulnerabilidad{
                Clave="CVE-2009-2504", Vendedor= "microsoft", 
                Descripcion= "Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1" , 
                Tipo= "local", Fecha=DateTime.Parse("13/11/2009")});
        r.Nodos[2].Vulnerabilidades.Add(
            new Vulnerabilidad{
                Clave="CVE-2016-7271", Vendedor= "microsoft", 
                Descripcion= "Elevación de privilegios Kernel Segura en Windows 10 Gold", 
                Tipo= "local", Fecha=DateTime.Parse("20/12/2016")});
        r.Nodos[2].Vulnerabilidades.Add(
            new Vulnerabilidad{
                Clave="CVE-2017-2996", Vendedor= "adobe", 
                Descripcion= "Adobe Flash Player 24.0.0.194 corrupción de memoria explotable" , 
                Tipo= "remota", Fecha=DateTime.Parse("15/02/2017")});

    }

    void Reporte(Red r){
        Console.WriteLine("Empresa de seguridad en redes SA de CV\n");
        Console.WriteLine("Datos generales de la red:\n");
        Console.WriteLine($"Empresa: {r.Empresa}");
        Console.WriteLine($"Propietario: {r.Propietario}");
        Console.WriteLine($"Domicilio: {r.Domicilio}");

        Console.WriteLine($"\nTotal nodos red: {r.Nodos.Count}");
        Console.WriteLine($"\nTotal vulnerabilidades: {r.TotVul()}");

        Console.WriteLine("\n>>Datos generales de los nodos: \n");
        r.Nodos.ForEach(n=>Console.WriteLine(n.ToString()));
        Console.WriteLine($"\nMayor numero de saltos: {r.MaySal()}");
        Console.WriteLine($"Menor numero de saltos: {r.MenSal()}");

        Console.WriteLine("\n>>Vulnerabilidades por nodo: \n");
        foreach(Nodo n in r.Nodos){
            Console.WriteLine($"\n> Ip:{n.Ip}, Tipo:{n.Tipo}");
            Console.WriteLine($"\nVulnerabilidades:{n.Vulnerabilidades.Count}");
            n.Vulnerabilidades.ForEach(v=>Console.WriteLine(v.ToString()));
        }
    }
        