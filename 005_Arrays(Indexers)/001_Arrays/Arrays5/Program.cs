using System;

// Абстрактный класс Array.

// Все массивы являются производными от класса Array.

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] vector = { 1, 2, 3 };

            Array array = vector as Array; //безопасноеприведение к базовому типу

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
