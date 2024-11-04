using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5ConsoleApp
{
    // Задание 5: Игра «Угадай число»
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное целое число диапазона:");
            int maxRange = int.Parse(Console.ReadLine());
            Random random = new Random();
            int secretNumber = random.Next(0, maxRange + 1);

            Console.WriteLine("Попробуйте угадать число!");
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine($"Вы сдались. Загаданное число: {secretNumber}");
                    break;
                }

                int guessedNumber = int.Parse(input);
                if (guessedNumber < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else if (guessedNumber > secretNumber)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else
                {
                    Console.WriteLine("Поздравляем! Вы угадали число!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
