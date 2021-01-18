using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Starter
{
    class Tasks21_27
    {
        public void Task21()
        {
            Console.WriteLine("Введите первое число: ");
            double number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            double number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" возвращает значение каждого аргумента деленного на 5: " + ((number1) / 5).ToString());
            Console.WriteLine(" возвращает значение каждого аргумента деленного на 5: " + ((number2) / 5).ToString());
            Console.WriteLine(" возвращает значение каждого аргумента деленного на 5: " + ((number3) / 5).ToString());
            Console.ReadKey();
        }
        public void Task22()
        {
            Task22 task22 = new Task22();
            task22.Task();
        }
        public void Task23()
        {
            Console.WriteLine("Задача была исключена");
        }
        public void Task24()
        {
            Console.WriteLine("Введите размерность массива:");
            var number = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[number];
            Random rand = new Random();

            for (int x = 0; x < arr.Length; x++)
            {
                arr[x] = rand.Next(0,50);
                Console.WriteLine("Значение элемента массива " + x + " = " + arr[x]);
            }
            var resultMax = arr.Max();
            var resultMin = arr.Min();
            var resultSum = arr.Sum();
            var resultAverage = arr.Average();
            for (int i = 0; i < arr.Length; i++)//Цикл вывода массива.
            {
                if (arr[i] % 2 != 0)//Если элемент массива нечётный, то умножаем его на 3.
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine($"\nМаксимальное хначение массива:{resultMax};" +
                $"\nМинимальное значение массива:{resultMin}" +
                $"\nСумма значение массива:{resultSum}" +
                $"\nСреднее значение элементов массива:{resultAverage}");
        }
        public void Task25()
        {
            Task25 task = new Task25();
            task.Task();
        }
        public void Task26()
        {
            Task26 task26 = new Task26();
            task26.Task();
        }
        public void Task27()
        {
            Task25 task = new Task25();
            int[] array =  task.MyArray();
            task.MyReverse(array);
        }
    }
}
