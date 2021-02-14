using System;
using System.Collections.Generic;

namespace _16.SistemaBancarioV1
{
    public class Banco
    {
        private string nombre;
        private string propietario;
        private List<Cliente> clientes;
        public Banco(string nombre, string propietario) {
            this.nombre=nombre;
            this.propietario=propietario;
            clientes=new List<Cliente>();
        }
        public string Nombre {
            get {return nombre;}
            
        }
        public string Propietario {
            get {return propietario;}
            
        }
        public List<Cliente> Clientes {
            get {return clientes;}
        }
        public void AgregarCliente(Cliente cliente) {
            clientes.Add(cliente );
        }
    }
}