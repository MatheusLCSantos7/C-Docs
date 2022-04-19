// See https://aka.ms/new-console-template for more information

		string[] resu =	new string[5] { " ", " "," ", " ", "" };
		int i = 0;
		
		
		Console.WriteLine("Telefonou para a vítima? ");
		string quest1 = Console.ReadLine();
		resu[0] = quest1;
		
		
		
		Console.WriteLine("Esteve no local do crime? ");
		string quest2 = Console.ReadLine();
		resu[1] = quest2;
		
		
		Console.WriteLine("Mora perto da vítima?");
		string quest3 = Console.ReadLine();
		resu[2] = quest3;
		
		
		Console.WriteLine("Devia para a vítima? ");
		string quest4 = Console.ReadLine();
		resu[3] = quest4;
		
		
		Console.WriteLine("Já trabalhou com a vítima?");
		string quest5 = Console.ReadLine();
		resu[4] = quest5;
		
		
		foreach (string result in resu)
 			{	
				if (result == "s")
				{
					i++;
				}
 			}
		
		switch(i)
		{
			case 2 : 			
				Console.WriteLine("Você é Suspeito");
				break;
		
			case 3 :			
				Console.WriteLine("Você é Cúmplise");
				break;
			case 4 :			
				Console.WriteLine("Você é Cúmplise");
				break;
			case 5	: 			
				Console.WriteLine("Você é Assassino");
				break;
			default : 
				Console.WriteLine("Você é inocente");
				break;
		
		}
		
