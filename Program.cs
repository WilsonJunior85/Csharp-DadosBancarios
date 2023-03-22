using System;
using System.Globalization;



namespace TESTE {
     class Program
   {
        private static double saldo;

        static void Main(string[] args)
	  {

            Conta_Bancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resultado = char.Parse(Console.ReadLine());
            if(resultado == 's' || resultado == 'S'){
                 Console.Write("Entre com o valor do depósito: ");
                 double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                 Console.Write("Dados atualizados: ");
                conta = new Conta_Bancaria(numero, titular, saldo);
                conta.Deposito(depositoInicial);
                Console.WriteLine(conta);
                

            }else{
                conta = new Conta_Bancaria(numero, titular);
            }




            Console.Write("Entre com o valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);





        }
    }
}