using System;

public class Program
{
	public static void Main()
	{

		string val;
		int res, i, j, a=0;
		do
		{
			Console.WriteLine("Entre le nombre: ");
			val = Console.ReadLine();
			res = Convert.ToInt32(val);
		} while (res < 0);

		for (j = 2; j < 10; j++)
		{
			if (res % j == 0)
				a++;
		}
		if (a == 1 || a == 0)
			Console.WriteLine("Ce nombre est premier");
		else
			Console.WriteLine("Ce nombre n'est pas premier");

	}			
}
