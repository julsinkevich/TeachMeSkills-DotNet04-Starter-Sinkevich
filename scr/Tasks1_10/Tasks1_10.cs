using Starter;
using System;
using System.Collections.Generic;
using System.Linq;

public class Tasks1_10
{
    public void Task1()
    {
        /*double pi = Math.PI;
         double constPi = 3.14159265d;
         double e = Math.E;
         Console.WriteLine($"\U000103C0 = {pi} \ne = {e}");*/

        decimal constPi = 3.141592653m;
        decimal constE = 2.7182818284590452m;

        Console.WriteLine("Pi is equal to: " + constPi + "\nNumber (Euler) e is equal to: " + constE);
        Console.ReadKey();
    }
    public void Task2()
    {
        string variableFirst = "My line 1";
        string variableSecond = "My line 2";
        string variableThird = "My line 3";

        Console.WriteLine($"\n{variableFirst}");
        Console.WriteLine($"\t{variableSecond}");
        Console.WriteLine($"\a{variableThird}");
        Console.ReadKey();
    }
    public void Task3()
    {
        double pi = Math.PI;
        Console.WriteLine("Enter the radius in mm.");
        var r = Convert.ToInt64(Console.ReadLine());
        int stepen = 2;
        var area = pi * Math.Pow(r, stepen);

        Console.WriteLine($"The area of a circle = {area}");
        Console.ReadKey();
    }
    public void Task4()
    {
        Console.WriteLine("Ведите сперва R (мм) - enter, затем h (мм) - enter");
        double R = Convert.ToDouble(Console.ReadLine());
        double h = Convert.ToDouble(Console.ReadLine());

        double V = (double)(Math.PI * R * R * h);
        double S = (double)(2 * Math.PI * R * (R + h));

        Console.WriteLine($"Объем V цилиндра радиусом – {R} и высотой – {h}, вычисляется по формуле: V = piR2h= {V}." +
           $"\nПлощадь S поверхности цилиндра вычисляется по формуле: S = 2piR2 h + 2piR2 = 2piR(R + h) = {S}.");
        Console.ReadKey();
    }
    public void Task5()
    {
        Console.WriteLine($"Введите два числа:");

        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());

        int addition = number1 + number2;
        Console.WriteLine($"+ {addition}");

        int subtraction = number1 - number2;
        Console.WriteLine($"- {subtraction}");

        int division = number1 / number2;
        Console.WriteLine($"/ {division}");

        int multiplication = number1 * number2;
        Console.WriteLine($"* {multiplication}");

        int remainderDivision = number1 % number2;
        Console.WriteLine($"% {remainderDivision}");

        int incremen = number1++;
        Console.WriteLine($"{number1} - {incremen}");

        int decrement = number2--;
        Console.WriteLine($"{number2} - {decrement}");
        Console.ReadKey();
    }
    public void Task6()
    {
        Console.WriteLine($"Введите первое число:");
        int operand1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Введите второе число:");
        int operand2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Введите операцию:");
        string sign = Console.ReadLine();
        switch (sign)
        {
            case "+":
                {
                    int decision = operand1 + operand2;
                    Console.WriteLine($"{operand1} + {operand2} = {decision}");
                    break;
                }
            case "-":
                {
                    int decision = operand1 - operand2;
                    Console.WriteLine($"{operand1} - {operand2} = {decision}");
                    break;
                }
            case "*":
                {
                    int decision = operand1 * operand2;
                    Console.WriteLine($"{operand1} * {operand2} = {decision}");
                    break;
                }
            case "/":
                {
                    if (operand2 != 0)
                    {
                        double decision = Convert.ToDouble(operand1) / Convert.ToDouble(operand2);
                        Console.WriteLine($"{operand1} / {operand2} = {decision}");
                    }
                    else
                    {
                        try
                        {
                            int a = 0;
                            int b = operand1 / a;
                            Console.Write(b);
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    break;
                }
            case "%":
                {
                    int decision = operand1 % operand2;
                    Console.WriteLine($"Остаток от деления {operand1} на {operand2} = {decision}");
                    break;
                }
            default:
                {
                    Console.WriteLine("Ви ввели некоректний не знак");
                    break;
                }
        }
        Console.ReadKey();
    }
    public void Task7()
    {
    first:
        Console.WriteLine("Число?");
        var number = Convert.ToInt32(Console.ReadLine());
        if (0 <= number & number <= 14)
        {
            Console.WriteLine($"Число {number} в промежутке от 0 до 14");
        }
        else if (15 <= number & number <= 35)
        {
            Console.WriteLine($"Число {number} в промежутке от 15 до 35");
        }
        else if (36 <= number & number < 50)
        {
            Console.WriteLine($"Число {number} в промежутке от 36 до 50");
        }
        else if (number == 50)
        {
            Console.WriteLine($"Число {number} в промежутке от 36 до 100");
        }
        else if (51 <= number & number <= 100)
        {
            Console.WriteLine($"Число {number} в промежутке от 51 до 100");
        }
        else
        {
            Console.WriteLine($"Число не входит ни в один из промежутков задачи.");
        }
        Console.WriteLine("Показать еше раз, да?");
        if (Console.ReadLine() == "да")
            goto first;
        Console.ReadLine();
    }
    public void Task8()
    {
        Russian_English[] russian_english ={
            new Russian_English{ EnglishSalute= "barometer", RussianSalute= "барометр"},
            new Russian_English{ EnglishSalute= "degrees", RussianSalute= "градусы"},
            new Russian_English{ EnglishSalute= "synoptic", RussianSalute= "синоптик"},
            new Russian_English{ EnglishSalute= "weather", RussianSalute= "погода"},
            new Russian_English{ EnglishSalute= "windy", RussianSalute= "ветер"},
            new Russian_English{ EnglishSalute= "sky", RussianSalute= "небо"},
            new Russian_English{ EnglishSalute= "sun", RussianSalute= "солнце"},
            new Russian_English{ EnglishSalute= "star", RussianSalute= "звезда"},
            new Russian_English{ EnglishSalute= "storm", RussianSalute= "шторм"},
            new Russian_English{ EnglishSalute= "thunder", RussianSalute= "гром"}
            };
        var result = russian_english.ToDictionary(k => k.EnglishSalute, v => v.RussianSalute);
        foreach (KeyValuePair<string, string> dic in result)
            Console.WriteLine(String.Format("English salute {0} is {1} in Russian", dic.Key, dic.Value));
        Console.ReadKey();
    }
    public void Task9()
    {
        int a;
        Console.WriteLine("введите число: ");
        a = Convert.ToInt32(Console.ReadLine());

        if (a % 2 == 0)
        {
            Console.WriteLine("четное число");

        }
        else
        {
            Console.WriteLine("нечетное");
        }
        Console.ReadKey();
    }
    public void Task10()
    {
        Console.WriteLine("Стаж работы (целых лет)? ");
        int experience = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Зарплата?");
        double salary = Convert.ToDouble(Console.ReadLine());
        if (experience < 5)
        {
            double prize = salary / 100 * 10;
            Console.WriteLine($"Итого: {salary} / 100 * 10 = {prize}");
        }
        else if (experience <= 5 && experience < 10)
        {
            double prize = salary / 100 * 15;
            Console.WriteLine($"Итого: {salary} / 100 * 15 = {prize}");
        }
        else if (experience <= 10 && experience < 15)
        {
            double prize = salary / 100 * 25;
            Console.WriteLine($"Итого: {salary} / 100 * 25 = {prize}");
        }
        else if (experience <= 15 && experience < 20)
        {
            double prize = salary / 100 * 35;
            Console.WriteLine($"Итого: {salary} / 100 * 35 = {prize}");
        }
        else if (experience <= 20 && experience < 25)
        {
            double prize = salary / 100 * 45;
            Console.WriteLine($"Итого: {salary} / 100 * 45 = {prize}");
        }
        else if (experience <= 25)
        {
            double prize = salary / 100 * 50;
            Console.WriteLine($"Итого: {salary} / 100 * 50 = {prize}");
        }
    }
}
