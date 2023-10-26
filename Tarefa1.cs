using System;

namespace ConsoleApp1
{
    class Tarefa1
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int b = 1;



            while (b >= 1)
            {
                Console.WriteLine("Voce poderá digitar uma sequencia de até 10 numeros, por favor evite a casa dos bilhões");
                Console.WriteLine("Digite um numero");
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                    if (numbers[i] % 2 == 0)
                    {
                        Console.WriteLine("o numero é par");
                    }
                    else
                    {
                        Console.WriteLine("O numero é impar");
                    }
                }


                b = --b;
                Console.WriteLine("Digite 1 para continuar, ou 2 para finalizar");
                int menu = int.Parse(Console.ReadLine());

                if (menu == 1)
                {
                   
                    b += menu;
                }
                else
                {
                    Console.WriteLine("Fim do programa");
                    break;
                }

            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);

        }
    }
}
