using System;

class Program
{
    static void Main()
    {
        // Объект Random для генерации случайного числа
        Random random = new Random();

        // Генерация случайного числа от 1 до 100
        int secretNumber = random.Next(1, 101);

        // Переменная для хранения ввода пользователя
        int userGuess;

        // Переменная для подсчета попыток
        int attempts = 0;        

        do
        {
            Console.Write("Число загадано. Попытайтесь угадать какое именно (от 1 до 100): ");

            // Преобразование ввода пользователя в число
            if (int.TryParse(Console.ReadLine(), out userGuess))
            {
                // Увеличиваем количество попыток
                attempts++;

                // Проверяем, угадал ли пользователь число
                if (userGuess == secretNumber)
                {
                    Console.WriteLine($"Поздравляю! Вы угадали число {secretNumber} за {attempts} попыток.");
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Число больше. Попробуйте еще раз.");
                }
                else
                {
                    Console.WriteLine("Число меньше. Попробуйте еще раз.");
                }
            }
            else
            {
                Console.WriteLine("Введите корректное число.");
            }

        } while (userGuess != secretNumber);
        
        Console.ReadLine();
    }
}