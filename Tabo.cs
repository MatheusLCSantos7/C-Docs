using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine($"Digite um número: \n");
		int num = int.Parse(Console.ReadLine());
		
		Console.WriteLine($"Digite até qual número deseja fazer a multiplicação \n");
		int i = int.Parse(Console.ReadLine());
		
		for (int j = 0; j <= i ; j++)
		{
			Console.WriteLine(num + " * " + j + " = " + num * j);
		}
		
	
		}
		
}
