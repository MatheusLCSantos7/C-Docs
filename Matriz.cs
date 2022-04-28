using System;
					
public class Program
{
	public static void Main()
	{
		int[,] matriz = new int[5,5];	
		string entrada;		
        int x ;
		string resposta ="não encontrado";
		
        do
           {
			Console.WriteLine("Digite qual valor você gostaria de localizar");
			 entrada = Console.ReadLine();
           }
        while (!int.TryParse(entrada, out x));
							
		for (int l = 0;l < 5; l++)
		{		
			for (int c = 0; c < 5; c++)
			{	
				Console.WriteLine($"\nLinha {l + 1} - Coluna {c}");    
				Console.WriteLine($"Digite o número que deverá ficar na linha {l + 1} e na coluna {c + 1}");
				string resu = (Console.ReadLine());
				matriz[l , c] = int.Parse(resu);
				
				if (matriz[l,c] == x) 
				{
					if(resposta == "não encontrado")
					{
						resposta = "";
					}
					resposta += $"\nO número {x} esta na linha {l + 1} e na coluna {c + 1}\n";
				}	
			}			
		}
		
		Console.WriteLine(resposta);	
	}
}
