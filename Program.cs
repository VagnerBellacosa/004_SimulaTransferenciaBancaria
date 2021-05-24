using System;
using System.Collections.Generic;
using System.Threading;

namespace DIO.Bank
{
	class Program
	{

		//*****************************************
		//*  Inserir Contas
		//*  Autor : Vagner Bellacosa
		//*  Data  : 24/05/2021
		//*  Bootcamp : Introduçao Dot Fundamental
		//*****************************************
			
		static List<Conta> listContas = new List<Conta>();

		static void Main(string[] args)
		{
			String LogoAbertura =  ObterOpcaoLogo(); 

			Thread.Sleep(2000);

			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarContas();
						break;
					case "2":
						InserirConta();
						break;
					case "3":
						Transferir();
						break;
					case "4":
						Sacar();
						break;
					case "5":
						Depositar();
						break;
                    case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}
			
			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
		}

		private static void Depositar()
		{
			//*****************************************
			//*  Depositar Contas
			//*  Autor : Vagner Bellacosa
			//*  Data  : 24/05/2021
			//*  Bootcamp : Introduçao Dot Fundamental
			//*****************************************

			Console.WriteLine();
			Console.WriteLine("________________________________");
			Console.WriteLine();
			Console.WriteLine(" Bellacosa Bank a seu dispor!!!");
			Console.WriteLine();
			Console.WriteLine();						
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser depositado: ");
			double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
		}

		private static void Sacar()
		{
			//*****************************************
			//*  Sacar Contas
			//*  Autor : Vagner Bellacosa
			//*  Data  : 24/05/2021
			//*  Bootcamp : Introduçao Dot Fundamental
			//*****************************************

		
			Console.WriteLine();
			Console.WriteLine("________________________________");
			Console.WriteLine();
			Console.WriteLine(" Bellacosa Bank a seu dispor!!!");
			Console.WriteLine();
			Console.Write("Digite o número da conta: ");
			
			int indiceConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser sacado: ");
			
			double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);
		}

		private static void Transferir()
		{
			//*****************************************
			//*  Transferir Contas
			//*  Autor : Vagner Bellacosa
			//*  Data  : 24/05/2021
			//*  Bootcamp : Introduçao Dot Fundamental
			//*****************************************

			Console.WriteLine();
			Console.WriteLine("________________________________");
			Console.WriteLine();
			Console.WriteLine(" Bellacosa Bank a seu dispor!!!");
			Console.WriteLine();
			Console.WriteLine("Transferencia Bancaria Interna");
			Console.WriteLine();
			Console.Write("Digite o número da conta de origem: ");
			int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de destino: ");
			int indiceContaDestino = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser transferido: ");
			double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);

			Console.WriteLine("________________________________");
			
			for (int i = 0; i < 4; i++)			{
				Console.WriteLine(" ");
			}

			Console.WriteLine(" (c) 2021 Bellacosa Adventures Softwares");
			Console.WriteLine(" ");

		}

		private static void InserirConta()
		{
			//*****************************************
			//*  Inserir Contas
			//*  Autor : Vagner Bellacosa
			//*  Data  : 24/05/2021
			//*  Bootcamp : Introduçao Dot Fundamental
			//*****************************************

			Console.WriteLine();
			Console.WriteLine("________________________________");
			Console.WriteLine();
			Console.WriteLine(" Bellacosa Bank a seu dispor!!!");
			Console.WriteLine();			
			Console.WriteLine("Inserir nova conta");
			Console.WriteLine("==================");
			Console.WriteLine();

			Console.Write("Digite 1 para Conta Fisica ou 2 para Juridica: ");
			int entradaTipoConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o Nome do Cliente: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite o saldo inicial: ");
			double entradaSaldo = double.Parse(Console.ReadLine());

			Console.Write("Digite o crédito: ");
			double entradaCredito = double.Parse(Console.ReadLine());

			Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
										saldo: entradaSaldo,
										credito: entradaCredito,
										nome: entradaNome);

			listContas.Add(novaConta);

			Console.WriteLine("________________________________");
			
			for (int i = 0; i < 4; i++)			{
				Console.WriteLine(" ");
			}

			Console.WriteLine(" (c) 2021 Bellacosa Adventures Softwares");
			Console.WriteLine(" ");

		}

		private static void ListarContas()
		{
			//*****************************************
			//*  Listar Contas
			//*  Autor : Vagner Bellacosa
			//*  Data  : 24/05/2021
			//*  Bootcamp : Introduçao Dot Fundamental
			//*****************************************

			Console.WriteLine("________________________________");
			Console.WriteLine();
			Console.WriteLine(" Bellacosa Bank a seu dispor!!!");
			Console.WriteLine();
			Console.WriteLine("Listar contas");
			Console.WriteLine("=============");
			Console.WriteLine();

			if (listContas.Count == 0)
			{
				Console.WriteLine();
				Console.WriteLine("Nenhuma conta cadastrada.");
				Console.WriteLine();
				Thread.Sleep(5000);	
				return;
			}

			for (int i = 0; i < listContas.Count; i++)
			{
				Conta conta = listContas[i];
				Console.WriteLine();
				Console.Write("#{0} - ", i);
				Console.WriteLine(conta);
			}
			Console.WriteLine();
			Console.WriteLine("________________________________");

			Thread.Sleep(8000);

			for (int i = 0; i < 4; i++)			{
				Console.WriteLine(" ");
			}

			Console.WriteLine(" (c) 2021 Bellacosa Adventures Softwares");
			Console.WriteLine(" ");

		}

		private static string ObterOpcaoUsuario()
		{
			//*****************************************
			//*  Menu principal
			//*  Autor : Vagner Bellacosa
			//*  Data  : 24/05/2021
			//*  Bootcamp : Introduçao Dot Fundamental
			//*****************************************
			Console.Clear();

			Console.WriteLine();
			Console.WriteLine("________________________________");
			Console.WriteLine();
			Console.WriteLine(" Bellacosa Bank a seu dispor!!!");
			Console.WriteLine();
			Console.WriteLine(" Informe a opção desejada:");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(" 1- Listar contas");
			Console.WriteLine(" 2- Inserir nova conta");
			Console.WriteLine(" 3- Transferir");
			Console.WriteLine(" 4- Sacar");
			Console.WriteLine(" 5- Depositar");
            Console.WriteLine(" C- Limpar Tela");
			Console.WriteLine(" X- Sair");
			Console.WriteLine();
			Console.WriteLine("________________________________");
			
			for (int i = 0; i < 4; i++)			{
				Console.WriteLine(" ");
			}
			Console.WriteLine(" (c) 2021 Bellacosa Adventures Softwares");
			Console.WriteLine(" ");

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}

		private static string ObterOpcaoLogo()
		{
			//*****************************************
			//*  logotipo de abertura
			//*  Autor : Vagner Bellacosa
			//*  Data  : 24/05/2021
			//*  Bootcamp : Introduçao Dot Fundamental
			//*****************************************
			Console.Clear();

			Console.WriteLine();
			Console.WriteLine("_________________________");
			Console.WriteLine("|                        |");
			Console.WriteLine("|      ┃╲　 　╱┃         |");
			Console.WriteLine("|      ┃ ╲▁▁╱ ┃╭━━╮     |");
			Console.WriteLine("|      ┃┏┳╮╭┳┓┃╰━╮┃     |");
			Console.WriteLine("|      ┃╰┻┛┗┻╯┃ ╭╯┃     |");
			Console.WriteLine("|      ┃  ◥◤ ┃ ┃╭╯     |");
			Console.WriteLine("|      ╰╱╱━━╲╲╯━┻ ┃     |");
			Console.WriteLine("|        ┃╰╯      ┃     |");
			Console.WriteLine("|        ┃┏┓┏━━┳┳┓┃     |");
			Console.WriteLine("|        ┃┃┃┃  ┃┃┃┃     |"); 
			Console.WriteLine("|        ╰╯╰╯  ╰╯╰╯     |");
			Console.WriteLine("|                       |");
			Console.WriteLine("|     BELLACOSA BANK    |");			
			Console.WriteLine("|     <press enter>     |");
			Console.WriteLine("|_______________________|");	

			for (int i = 0; i < 4; i++)			{
				Console.WriteLine(" ");
			}
			Console.WriteLine(" (c) 2021 Bellacosa Adventures Softwares");
			Console.WriteLine(" ");

			string opcaoTecla = Console.ReadLine().ToUpper();
			
			Console.WriteLine();

			Thread.Sleep(2000);

			return opcaoTecla;
		}

	}
}
