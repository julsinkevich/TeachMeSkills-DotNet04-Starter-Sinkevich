using System;
using System.Collections.Generic;
using System.Text;


    public class Task18
    {
        private static int input = Convert.ToInt32(Console.ReadLine());

        public void Task()
        {
            Console.WriteLine("Введите число:");
            PositiveOrNegative();
            Prime();
            Multiplicity();
            Console.ReadKey();
        }
        public void PositiveOrNegative()
        {
            if (input > 0)
            {
                Console.WriteLine($"Число {input} положительное.");
            }
            else if (input == 0)
            {
                Console.WriteLine($"Число {input} = 0.");
            }
            else
            {
                Console.WriteLine($"Число {input} отрицательное.");
            }
        }
        public bool Prime()
        {
            var n = input;
            if (n > 1)
            {
                for (int i = 2; i < n; i++)// в цикле перебираем числа от 2 до n - 1
                    if (n % i == 0) //если n делится без остатка на i - возвращаем false (число не простое)
                    {
                        Console.WriteLine("Число не простое");
                        return false;
                    }
                {
                    Console.WriteLine("Число простое");
                    return true;//если программа дошла до данного оператора, то возвращаем true (число простое) - проверка пройдена
                }
            }
            else //иначе возвращаем false (число не простое)
            {
                Console.WriteLine("Число не простое");
                return false;
            }
        }
        public void Multiplicity()
        {
            if (input % 2 == 0 || input % 3 == 0 || input % 5 == 0 || input % 6 == 0 || input % 9 == 0)
            {
                Console.WriteLine("Число делится на 2,3,5,6 или 9 без остатка");
            }
            else
            {
                Console.WriteLine("Число не делится на 2,3,5,6 или 9 без остатка");
            }
        }
    }

