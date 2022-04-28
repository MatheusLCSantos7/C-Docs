using System;
using System.Collections.Generic;
public class Program
{
	public static void Main()
	{
		List<string> li = new List<string>();
		Console.WriteLine("Digita qual(s) nome(s) deseja inserir na lista ");	
	    string quest = "";

		do {
		string name = Console.ReadLine();
		li.Add(name);
		Console.WriteLine("\nDeseja inserir outro nome?");
		quest = Console.ReadLine();
		}
		while(quest != "não");
		
		Console.WriteLine($"Um total de {li.Count} nomes foram adicionados\n");
		Console.WriteLine("Os nomes adicionados foram: \n");
			
		foreach (string  nomes in li)
		{
			Console.WriteLine(nomes);
		}
	}
}
