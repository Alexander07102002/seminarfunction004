using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            int number;

            // Проверка на корректность введенного числа
            if (int.TryParse(input, out number))
            {
                int sum = SumDigits(number);
                Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
            }
            else
            {
                Console.WriteLine("Введенная строка не является числом!");
            }

            Console.ReadKey();
        }

        // Метод для вычисления суммы цифр
        static int SumDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;  // Добавляем последнюю цифру числа к сумме
                n /= 10;        // Отбрасываем последнюю цифру числа
            }
            return sum;
        }
    }
}
