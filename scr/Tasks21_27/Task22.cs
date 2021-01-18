using System;
using System.Collections.Generic;
using System.Text;

namespace Starter
{
   public class Task22
    {
        public void Task()
        {
            Account acc = new Account(0);

            string task;
            do
            {
                Console.WriteLine("Хотите произвести операцию со счетом?(y/n):");
                task = Console.ReadLine();
                if (task == "y")
                {
                    Console.WriteLine("Введите сумму:");
                    int input = Convert.ToInt32(Console.ReadLine());
                    acc.Put(input);    // добавляем на счет 
                    Console.WriteLine($"Сумма на счете: {acc.Sum}");
                    if (acc.Sum >= 1000)
                    {
                        acc.Notify += DisplayMessage;   // Добавляем обработчик для события Notify
                        acc.Take(input);
                    }
                }
            }
            while (task != "n");
            Console.ReadKey();
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
    class Account
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;// Определение события
        public Account(int sum)
        {
            Sum = sum;
        }
        public int Sum { get; private set; }// сумма на счете
        public void Put(int sum)
        {
            Sum += sum;// добавление средств на счет
            Console.WriteLine($"На счет поступило: {sum}");
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;// списание средств со счета
                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                Notify?.Invoke("Добби свободен!");   // Вызов события
                Console.ResetColor(); // сбрасываем в стандартный
            }
            else
            {
                Notify?.Invoke("Добби не свободен:(");
            }
        }
    }
}
