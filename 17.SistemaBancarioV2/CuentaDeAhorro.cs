namespace _16.SistemaBancarioV1
{   
    public class CuentaDeAhorro : CuentaBancaria //herencia
    {     private double tasadeinteres;
          
        public CuentaDeAhorro(double saldo,double tasadeinteres)
            : base(saldo)//llamada explicita al constructor base
            {
                this.tasadeinteres=tasadeinteres;
            }

        public void CalcularInteres(){
            saldo+=saldo*tasadeinteres;
        }
        
    }
}