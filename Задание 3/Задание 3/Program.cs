using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первую строку:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Введите вторую строку:");
        string str2 = Console.ReadLine();

        // Используем метод Contains для проверки, является ли строка 2 подстрокой строки 1
        if (str1.Contains(str2))
        {
            Console.WriteLine("Вторая строка является подстрокой первой строки.");
        }
        else
        {
            Console.WriteLine("Вторая строка не является подстрокой первой строки.");
        }

        // Задерживаем консоль, чтобы пользователь мог увидеть результат
        Console.ReadLine();
    }
}
