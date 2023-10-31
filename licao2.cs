/*
 * Created by SharpDevelop.
 * User: guui_
 * Date: 18/09/2023
 * Time: 09:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;

namespace yrdy
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Só sei 2 maneiras de fazer");
			Console.WriteLine("E em nenhuma consegui usar o range nos slices :c");
			Console.WriteLine("EXEMPLO: numbers [0..4]");
			Console.WriteLine("Anyway \r\nVamos ao codigo");
			
			int[] numbers = new int[5];
			
			
			Console.WriteLine("Digite uma sequencia de 5 numeros");
			for (int i = 0; i < 5; i++) {
				numbers[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine("Digite 1 para somar via Lib do proprio csharp e 2 do jeito mais PRIMITIVO");
			int menu = int.Parse(Console.ReadLine());
			
			int resultado = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];
			
			if (menu == 1) {
				Console.WriteLine("O resultado da soma é: " + numbers.Sum());
			}
			else if (menu == 2) {
				Console.WriteLine("O resultado da soma é: " + resultado);
			}
			else {
				Console.WriteLine("Era pra digitar um valor valido cara");
			}
			
			Console.WriteLine("Digite qualquer coisa para encerrar o programa");
			Console.ReadKey(true);
		}
	}
}