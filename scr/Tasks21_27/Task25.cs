using System;
using System.Collections.Generic;
using System.Text;

namespace Starter
{
    public class Task25
    {
        public void Task()
        {
            int[] myArray = MyArray();
            int[] array = MyReverse(myArray);
            Console.Write("Enter count element array: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter index start array: ");
            int index = Convert.ToInt32(Console.ReadLine());

            SubArray(array, index, count);
            Console.ReadKey();
        }
        public int[] MyArray()
        {
            Random myRnd = new Random();// Объявляется генератор случайных чисел.
            int[] array = new int[10];//Объявление целочисленного массива длинной 10.
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)//Цикл заполнения массива.
            {
                array[i] = myRnd.Next(1, 10);//Присвоение случайного числа от 1 до 10 [i]-тому элементу массива.
                Console.Write(array[i] + " ");//Вывод на экран.
            }
            return array;
        }
        public int[] MyReverse(int[] array)
        {
            Console.WriteLine("\nМасив в обратном порядке:");
            Array.Reverse(array);
            foreach (var i in array)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            return array;
        }
        private static void SubArray(int[] array, int index, int count)
        {
            int newLenght = count;
            int lenght;

            if (array.Length < newLenght)
            {
                lenght = array.Length + newLenght;
            }
            else
            {
                lenght = array.Length;
            }
            int[] newArray = new int[lenght];

            for (int i = index; i < count; i++)
            {
                if (i < array.Length)
                {
                    newArray[i] = array[i];
                    Console.WriteLine(newArray[i]);

                }
                else
                {
                    newArray[i] = 1;
                    Console.WriteLine(newArray[i]);

                }
            }
        }

    }
}
