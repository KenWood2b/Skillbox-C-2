using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4ConsoleApp
{
    // Задание 4: Наименьший элемент в последовательности
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности:");
            int length = int.Parse(Console.ReadLine());
            int minValue = int.MaxValue;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Введите {i + 1}-е число:");
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < minValue)
                {
                    minValue = currentNumber;
                }
            }

            Console.WriteLine($"Наименьшее число в последовательности: {minValue}");
            Console.ReadKey();
        }
    }
}
