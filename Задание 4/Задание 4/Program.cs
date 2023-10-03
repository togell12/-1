using System;

class Program
{
    static void Main()
    {
        // Объект Random для генерации случайных чисел
        Random random = new Random();

        // Создаем массив из 10 целых чисел
        int[] array = new int[10];

        // Заполняем массив случайными числами и выводим каждый элемент
        Console.WriteLine("Элементы массива:");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101); // Генерация случайного числа от 1 до 100
            Console.WriteLine($"Элемент {i + 1}: {array[i]}");
        }

        // Вычисляем сумму элементов массива
        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }

        // Выводим сумму
        Console.WriteLine($"Сумма элементов массива: {sum}");

        Console.ReadLine();
    }
}
