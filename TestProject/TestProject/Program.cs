using System;
using System.Globalization;

namespace TestProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Conta conta;

			Console.Write("Entre o Número da conta: ");
			int numeroConta = int.Parse(Console.ReadLine());
			Console.Write("Entre o nome do titular da conta: ");
			string nomeTitular = Console.ReadLine();
			Console.Write("Haverá depósito inicial? s/n");
			char controlDepositoInicial = char.Parse(Console.ReadLine());
			
			if(controlDepositoInicial.Equals('s') || controlDepositoInicial.Equals('S'))
            {
				Console.Write("Entre o valor do deposito inicial: ");
				double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				conta = new Conta(numeroConta, nomeTitular, depositoInicial);
            }
            else
            {
				conta = new Conta(numeroConta, nomeTitular);
            }

			Console.WriteLine("Dados da conta: ");
			Console.WriteLine(conta.ToString());

			Console.WriteLine("Entre um valor pra deposito: ");
			double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			conta.deposito(deposito);
			Console.WriteLine("Dados da conta atualizados: ");
			Console.WriteLine(conta.ToString());

			Console.WriteLine("Digite um valor para saque: ");
			double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			conta.saque(saque);
			Console.WriteLine("Dados da conta atualizados: ");
			Console.WriteLine(conta.ToString());

		}
	}
}
