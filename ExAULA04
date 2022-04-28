using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Dictionary<string, string> leangue =  new Dictionary<string, string>();
		int choice = 0;
		bool continua = true;
		string adicio1 = "";
		string adicio2 = "";
		
		
		do {
		Console.WriteLine($"\nM E N U\nEscolha o número de qual ação queira realizar\n1 - Inserir sigla e idioma\n2 - Pesquisar sigla\n3 - Remover sigla\n4 - Pesquisar idioma\n5 - Sair");
		choice = int.Parse(Console.ReadLine());
		switch(choice)
		{
				
			case 1:
				Console.WriteLine($"Ao inserir, siga o formato: pt-BR, Portuguese Brazil");
				Console.WriteLine("Insira uma sigla e um idioma: ");
				adicio1 = Console.ReadLine();
				adicio2 = Console.ReadLine();
				leangue.Add(adicio1, adicio2);
				break;
			case 2:
				string quey = "";
				Console.WriteLine("Insira a sigla que deseje pesquisar:");
				quey = Console.ReadLine();
				leangue.ContainsKey(quey);
				if (leangue.ContainsKey(quey))
					{
						Console.WriteLine($"A sigla {quey} existe ");
						Console.WriteLine($"E seu idioma é {leangue[quey]}");
					} else
					{
						Console.WriteLine($"A sigla {quey} não existe");
					}
					break;
			case 3:
				Console.WriteLine("Insira a sigla que deseja remover: ");
				string remo = "";
				remo = Console.ReadLine();
				if (leangue.ContainsKey(remo))
					{
						leangue.Remove(remo);
					Console.WriteLine($"A sigla {remo} foi extinguida");
					}
				break;
			case 4:
			Console.WriteLine("Insira o idioma que deseje pesquisar: ");
			string name = "";
			name = Console.ReadLine();
			foreach(KeyValuePair<string, string> informacao in leangue)
            {	
				if (informacao.Value == name)
				{
					Console.WriteLine($"Sua sigla foi  {informacao.Key}");				
				}
			}

				break;
			case 5: 
				continua = false;
				break;
			
		}
		} while(continua);		
	}
}
