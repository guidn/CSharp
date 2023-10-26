using System;

namespace ConsoleApp1
{
    class Tarefa3
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Digite um numero de 1 a 7 para saber se é dia util ou não");
			int dia = int.Parse(Console.ReadLine());

			if (dia == 1 || dia == 7)
			{
				Console.WriteLine("Final de semana");
			}
			else if (dia >= 2 && dia <= 6)
			{
				Console.WriteLine("E Dia Util");
			}
			else
			{
				Console.WriteLine("Dia invalido");
			}

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
    }
}
