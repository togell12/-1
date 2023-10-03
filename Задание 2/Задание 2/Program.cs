using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите три числа для расчета среднего арифметического.");

        // Переменные для хранения введенных пользователем чисел
        double number1, number2, number3;
        
        Console.Write("Введите первое число: ");
        if (double.TryParse(Console.ReadLine(), out number1))
        {
            Console.Write("Введите второе число: ");
            if (double.TryParse(Console.ReadLine(), out number2))
            {
                Console.Write("Введите третье число: ");
                if (double.TryParse(Console.ReadLine(), out number3))
                {
                    // Вычисляем среднее арифметическое
                    double average = (number1 + number2 + number3) / 3;

                    // Выводим результат
                    Console.WriteLine($"Среднее арифметическое: {average}");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода для третьего числа.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода для второго числа.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода для первого числа.");
        }

        Console.ReadLine();
    }
}