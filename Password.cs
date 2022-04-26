using System;
					
public class Program
{
	public static void Main()
	{
		int senha = 0;
		int validação = 5190;
		bool logon = false;
		int i = 0;
		
		Console.WriteLine("Digite a senha: ");
		do
		{
			senha = int.Parse(Console.ReadLine());
			if(senha == validação)
			{
				Console.WriteLine("Senha Correta,Bem Vindo!!");
				logon = true;
			} else 
				
			{
				Console.WriteLine($"Senha incorreta\n");
				i++;
				if(i < 3)
				{
				Console.WriteLine("Digite a senha novamente ");
				}				
			}			
		}while(i<3 && !logon);
		
		if(!logon)
		{
			Console.WriteLine("Senha bloqueada!");
		}
		
	}
	
}
