using System;

namespace _16.SistemaBancarioV1
{
    public class CuentaBancaria
    {
        private double saldo;

        //Propiedad de solo lectura
        public CuentaBancaria(double saldo){
            this.saldo = saldo;
        }

        public double Saldo{
            get{return saldo;}
        }

        public void Deposita(double cant){
            saldo+=cant;
        }

        public bool Retira(double cant){
            if(saldo>=cant){
                saldo-=cant;
                return true;
            }
            else
                return false;
        }
    }
}