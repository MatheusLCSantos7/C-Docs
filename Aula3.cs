        Console.WriteLine("ANALISADOR DE TRIÂNGULOS");
		
		int[] ladoTriangle = new int[3];
		
		Console.WriteLine($"Digite o valor do primeiro lado:  \n");
		ladoTriangle[0] = int.Parse(Console.ReadLine());
		
		Console.WriteLine($"Digite o valor do segundo lado:  \n");
		ladoTriangle[1] = int.Parse(Console.ReadLine());
		
		Console.WriteLine($"Digite o valor do terceiro lado:  \n");
		ladoTriangle[2] = int.Parse(Console.ReadLine());
		
		if ((ladoTriangle[0] == ladoTriangle[1]) && ladoTriangle[1] == ladoTriangle[2] && ladoTriangle[0] == ladoTriangle[2] )
            {
                Console.WriteLine($"É um Triângulo Equilátero\n");
            } else if ((ladoTriangle[0] != ladoTriangle[1]) && ladoTriangle[1] != ladoTriangle[2] && ladoTriangle[0] != ladoTriangle[2] )
            {
                Console.WriteLine($"É um Triângulo Escaleno\n"); 
			}
			else
			{
				 Console.WriteLine($"É um Triângulo Isóceles \n");
				}
