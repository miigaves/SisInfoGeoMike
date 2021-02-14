using System;

namespace _16.SistemaBancarioV1
{
    class Program
    {
        static void Main(string[] args)
        {   bool retiro;
            Banco mibanco = new Banco ("La mina","Paola Medina");
            CuentaBancaria micuenta1 = new CuentaBancaria(100);
            CuentaBancaria micuenta2 = new CuentaBancaria(300);
            
            Cliente micliente1= new Cliente("Juan Perez");
            Cliente micliente2= new Cliente("Maria Ruiz");
            Cliente micliente3= new Cliente();
            micliente3.Nombre="Miguel Mendoza";

            micuenta1.Deposita(300);

            retiro =micuenta2.Retira(500);
            if(retiro) Console.Write("Retiro exitose");
            else Console.WriteLine("No se puede retirar la cantidad solicitada");
            
            micliente3.Cuenta.Deposita(10000);
            micliente2.Cuenta.Retira(100);
            //salidas
            mibanco.AgregarCliente(micliente1);
            mibanco.AgregarCliente(micliente2);
            mibanco.AgregarCliente(micliente3);
            mibanco.AgregarCliente(new Cliente("Ruben Ibarra"));
            mibanco.Clientes[3].Cuenta=new CuentaBancaria(50000);
             
            Console.WriteLine("Control bancario");
            Console.WriteLine("Saldo cuenta 1: {0}",micuenta1.Saldo);
            Console.WriteLine("Saldo cuenta 2: {0}",micuenta2.Saldo);

            Console.WriteLine("Cliente 1: Nombre{0}, Saldo{1}",micliente1.Nombre,micliente1.Cuenta.Saldo);
            Console.WriteLine("Cliente 2: Nombre{0}, Saldo{1}",micliente2.Nombre,micliente2.Cuenta.Saldo);
            Console.WriteLine("Cliente 3: Nombre{0}, Saldo{1}",micliente3.Nombre ,micliente3.Cuenta.Saldo);

            //Reporte bancario
            Console.WriteLine("\nReporte Bancario");
            Console.WriteLine($"Banco: {mibanco.Nombre}, Propietario: {mibanco.Propietario}");
            foreach(Cliente cte in mibanco.Clientes){
                Console.WriteLine($"Nombre {cte.Nombre}, saldo: {cte.Cuenta.Saldo}");
            }
            Console.WriteLine("\nTotal de clientes {0}",mibanco.Clientes.Count);
        }
    }
}