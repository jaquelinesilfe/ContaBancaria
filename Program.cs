using System;
using System.Globalization;

namespace ContaBancaria {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.WriteLine("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial? (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            if  (resposta == 's' || resposta == 'S') {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            } else {
                conta = new ContaBancaria(numero, titular);
            }


            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com o valor do depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.WriteLine("Entre com o valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorSaque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


        }
    }
}
