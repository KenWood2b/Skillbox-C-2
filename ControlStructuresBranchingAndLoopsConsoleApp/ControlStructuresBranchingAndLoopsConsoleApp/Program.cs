using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructuresBranchingAndLoopsConsoleApp
{
    // Задание 1: Приложение по определению чётного или нечётного числа

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Число чётное.");
            }
            else
            {
                Console.WriteLine("Число нечётное.");
            }
            Console.ReadKey();
        }
    }

}
