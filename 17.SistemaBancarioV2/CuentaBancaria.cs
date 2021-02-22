using System;

namespace _16.SistemaBancarioV1
{
    public class CuentaBancaria
    {
        protected double saldo;

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

        public virtual bool Retira(double cant){
            if(saldo>=cant){
                saldo-=cant;
                return true;
            }
            else
                return false;
        }
    }
}
   