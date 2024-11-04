using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3ConsoleApp
{
    // Задание 3: Проверка простого числа
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число для проверки на простоту:");
            int number = int.Parse(Console.ReadLine());
            bool isNotPrime = false;

            if (number <= 1)
            {
                isNotPrime = true;
            }
            else
            {
                int i = 2;
                while (i <= number / 2)
                {
                    if (number % i == 0)
                    {
                        isNotPrime = true;
                        break;
                    }
                    i++;
                }
            }

            if (isNotPrime)
            {
                Console.WriteLine("Число не является простым.");
            }
            else
            {
                Console.WriteLine("Число простое.");
            }
            Console.ReadKey();

        }
    }
}
