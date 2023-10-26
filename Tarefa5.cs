using System;

namespace ConsoleApp1
{
    class Tarefa5
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Por favor, utilize virgula");
			Console.WriteLine("Digite seu peso aqui");
			Double peso = Double.Parse(Console.ReadLine());

			Console.WriteLine("Digite sua altura aqui");
			float altura = float.Parse(Console.ReadLine());

			Double resultado = peso / (altura * altura);

			Console.WriteLine("Seu IMC é de: " + resultado);

			if (resultado <= 25)
			{
				Console.WriteLine("Seu peso está normal");
			}
			else
			{
				Console.WriteLine("Voce está acima do peso");
			}

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
    }
}
