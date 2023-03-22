using System;
using System.Globalization;


namespace TESTE
{
    public class Conta_Bancaria
    {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public Conta_Bancaria(int numero, string titular, double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
            
         }

        public Conta_Bancaria(int numero, string? titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public void Deposito( double deposito ){
          Saldo = Saldo + deposito;

         }

         public void Saque (double saque){

            Saldo = (Saldo - saque) - 5.0;
         }




        public override string ToString()
        {
            return "Conta: " 
            + Numero + "  " +
            "Titular: " + "  " +
            Titular + "  " +
            "Saldo: " + "  " +
            Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

        
    }






}
