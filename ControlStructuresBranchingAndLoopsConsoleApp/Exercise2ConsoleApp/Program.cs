using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2ConsoleApp
{
    // Задание 2: Программа подсчёта суммы карт в игре «21»
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Сколько у вас на руках карт?");
            int cardCount = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 1; i <= cardCount; i++)
            {
                Console.WriteLine($"Введите номинал {i}-й карты (2-10, J, Q, K, T):");
                string card = Console.ReadLine();

                switch (card)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        totalSum += 10;
                        break;
                    default:
                        totalSum += int.Parse(card);
                        break;
                }
            }

            Console.WriteLine($"Сумма ваших карт: {totalSum}");
            Console.ReadKey();
        }
    }
}
