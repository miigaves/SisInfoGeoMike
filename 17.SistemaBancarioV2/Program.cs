using System;

namespace _16.SistemaBancarioV1
{
    class Program
    {
         static void Main(string[] args){
             Banco mibanco = new Banco("Patito SA de CV","Mac Patito");

             mibanco.AgregarCliente(new Cliente("Amalia García"));
             mibanco.AgregarCliente(new Cliente("Miguel Alonso"));
             mibanco.AgregarCliente(new Cliente("Alejandro Tello"));
             mibanco.AgregarCliente(new Cliente("Ricardo Monreal"));

             mibanco.Clientes[0].AgregarCuenta(new CuentaDeAhorro(5000,.10));
             mibanco.Clientes[0].AgregarCuenta(new CuentaDeCheques(15000,400));

             mibanco.Clientes[1].AgregarCuenta(new CuentaDeAhorro(5600,.10));
             mibanco.Clientes[1].AgregarCuenta(new CuentaDeCheques(17000,400));

             mibanco.Clientes[2].AgregarCuenta(new CuentaDeAhorro(5500,.10));
             mibanco.Clientes[2].AgregarCuenta(new CuentaDeCheques(1000,400));

             mibanco.Clientes[3].AgregarCuenta(new CuentaDeAhorro(3000,.10));
             mibanco.Clientes[3].AgregarCuenta(new CuentaDeCheques(16000,400));
             
             Console.WriteLine("\n Reporte Bancario");
             Console.WriteLine("Banco {0} Propietario: {1}",mibanco.Nombre,mibanco.Propietario);
             foreach(Cliente cte in mibanco.Clientes){
                 Console.WriteLine($"Nombre:{cte.Nombre}, Tiene {cte.Cuentas.Count} cuentas");
                foreach(CuentaBancaria cta in cte.Cuentas){
                    Console.Write((cta is CuentaBancaria) ? "Cuenta de Cheques: ": "Cuenta de Ahorro:");
                    Console.WriteLine($"{cta.Saldo}");
             }
            }

         }
        static void PruebaCuentas()
        {   
            CuentaDeAhorro miahorr1=new CuentaDeAhorro(5500,0.1);
            CuentaDeCheques micheque1 = new CuentaDeCheques(900,500);

            //Mi ahorro           
            miahorr1.Deposita(1500);
            miahorr1.Retira(100);
            Console.WriteLine("Mi ahorro 1 {0}",miahorr1.Saldo);
            miahorr1.CalcularInteres();
            Console.WriteLine("Mi ahorro 1 {0}",miahorr1.Saldo);

            //micheque

            micheque1.Deposita(100);
            Console.WriteLine("mi cheque 1 {0}",micheque1.Saldo);
            micheque1.Retira(1400);
            Console.WriteLine("mi cheque 1 {0}",micheque1.Saldo);
            if(micheque1.Retira(150))
                Console.WriteLine("Retiro exitoso");
            else
                Console.WriteLine("Te pasaste...");
        }
    }
}