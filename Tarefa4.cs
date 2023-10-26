using System;

namespace ConsoleApp1
{
    class Tarefa4
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Digite um numero");
			int num = int.Parse(Console.ReadLine());

			if (num % 3 == 0)
			{
				Console.WriteLine("multiplo por 3");
			}
			else
			{
				Console.WriteLine("NÃO é multiplo por 3");
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
    }
}
