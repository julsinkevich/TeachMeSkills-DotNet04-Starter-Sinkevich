using Starter.Task11_20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Tasks11_20
{
    public void Task11()
    {
        Console.WriteLine("Введите число:");
        int a = Convert.ToInt32(Console.ReadLine());
        if (step(a)) Console.WriteLine("yes");
        else Console.WriteLine("No");
        Console.ReadKey();
    }
    public static bool step(int a)
    {
        if (a == 2) return true;
        else if (a % 2 == 0) return step(a / 2);
        else return false;
    }
    public void Task12()
    {
        Console.WriteLine("Разрешено не выполнять");
        int[] ab = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
        Console.WriteLine(Enumerable.Range(ab[0] + 1, ab[1] - ab[0] - 1).Sum());
    }
    public void Task13()
    {
        Console.WriteLine("Ввведите два числа через Enter");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        if (number2 > number1)
        {
            int sum = 0;
            for (int i = number1 + 1; i < number2; i++)
            {
                sum += i;
            }
            Console.Write("Сумма: " + sum);
            for (int i = number1 + 1; i < number2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("\nНечетные числа: " + i);
                }
            }
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Второе число должно быть больше предыдущего. Введите снова.");
        }
    }
    public void Task14()
    {
        Console.WriteLine("Треугольник");
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < i; j++)
            {

                Console.Write("*");
            }
            Console.WriteLine("*");
            //Console.Write(" ");
        }
        Console.WriteLine("Пустой треугольник");
        {
            int i1 = 0, i2 = 0;
            for (int a = 0; a < 8; a++)
            {
                for (int b = 0; b < 9; b++)
                {

                    if (b == i1 || b == i2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
                i2++;
            }
            for (int b = 0; b < 9; b++)
            {
                Console.Write("*");
            }
            Console.Read();
        }
        Console.WriteLine("Прямоугольник");
        {
            for (int i = 1; i < 10; i++)
            {
                Console.Write("* ");
            }
            for (int i = 1; i < 5; i++)
            {
                Console.Write("\n*               *");
            }
            for (int i = 1; i < 5; i++)
            {
                Console.Write("");
            }
            Console.Write("\n");
            for (int i = 1; i < 10; i++)
            {
                Console.Write("* ");
            }
        }
        Console.WriteLine("\nРавносторонний");
        {
            Console.Write("      *");
            Console.Write("\n   *    *");
            Console.Write("\n *        *");
            Console.Write("\n* * * * * * *");
        }
        Console.ReadKey();
    }
    public void Task15()
    {
        Console.WriteLine("Сколько клиентов?");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        do
        {
            result *= number;
            number -= 1;
        }
        while (number > 0);
        Console.WriteLine("Варианты доставки: {0}", result);
        Console.ReadKey();
    }
    public void Task16()
    {
        Console.WriteLine("Введите lenght и width: ");
        int lenght = Convert.ToInt32(Console.ReadLine()), width = Convert.ToInt32(Console.ReadLine());
        for (int number = 0; number < width; number++)
        {
            for (int num = 0; num < lenght; num++)
            {
                if (number == 0 || number == width - 1) Console.Write("*");
                else if (num == 0 || num == lenght - 1) Console.Write("*");
                else Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    public void Task17()
    {
        Currency[] bunCurrencies =
        {
            new Currency{CurrencyType="USD", Factor= 2.63d},
            new Currency{CurrencyType="EUR", Factor= 3.07d},
            new Currency{CurrencyType="RUB", Factor= 0.033d},
        };
        var result = bunCurrencies.ToDictionary(k => k.CurrencyType, v => v.Factor);
        Console.WriteLine("Введите сумму, которую хотите конвертировать в BUN:");
        var sum = Convert.ToDouble(Console.ReadLine());

        foreach (KeyValuePair<string, double> dic in result)
        {
            var value = Convert.ToDouble(dic.Value);
            double convert = value * sum;
            Console.WriteLine($"Currency {sum} {dic.Key} is {convert} in BUN");
        }
        Console.ReadKey();
    }
    public void Task18()
    {
        Task18 task18 = new Task18();
        task18.Task();
        //отдельный класс
    }
    public void Task19()
    {

        Console.Write("N = ");
        var number = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine("Простые и составные числа из диапазона ({0}, {1})", 0, number);
        for (var i = 0u; i < number; i++)
        {
            if (IsPrimeNumber(i))
            {
                Console.Write($"{i} ");
            }
        }
    }
    private static bool IsPrimeNumber(uint n)
    {
        if (n > 1)
        {
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        else
            return false;
    }
    public void Task20()
    {
        Console.WriteLine("Введите первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третье число: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Среднее арифметическое: " + ((number1 + number2 + number3) / 3).ToString());
        Console.ReadKey();
    }
}

