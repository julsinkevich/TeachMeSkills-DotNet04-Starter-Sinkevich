using System;

namespace Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks1_10 tasks1_10 = new Tasks1_10();
            Tasks11_20 tasks11_20 = new Tasks11_20();
            Tasks21_27 tasks21_27 = new Tasks21_27();
            while (true)
            {
                Console.WriteLine("Условие задач-читайте README");
                Console.WriteLine("Введите номер задачи:");
                Console.ForegroundColor = ConsoleColor.Green;
                int.TryParse(Console.ReadLine(), out int userInput);
                Console.ForegroundColor = ConsoleColor.White;
                switch (userInput)
                {
                    case 1:
                        tasks1_10.Task1();
                        break;

                    case 2:
                        tasks1_10.Task2();
                        break;
                    case 3:
                        tasks1_10.Task3();
                        break;
                    case 4:
                        tasks1_10.Task4();
                        break;
                    case 5:
                        tasks1_10.Task5();
                        break;
                    case 6:
                        tasks1_10.Task6();
                        break;
                    case 7:
                        tasks1_10.Task7();
                        break;
                    case 8:
                        tasks1_10.Task8();
                        break;
                    case 9:
                        tasks1_10.Task9();
                        break;
                    case 10:
                        tasks1_10.Task10();
                        break;
                    case 11:
                        tasks11_20.Task11();
                        break;
                    case 12:
                        tasks11_20.Task12();
                        break;
                    case 13:
                        tasks11_20.Task13();
                        break;
                    case 14:
                        tasks11_20.Task14();
                        break;
                    case 15:
                        tasks11_20.Task15();
                        break;
                    case 16:
                        tasks11_20.Task16();
                        break;
                    case 17:
                        tasks11_20.Task17();
                        break;
                    case 18:
                        tasks11_20.Task18();
                        break;
                    case 19:
                        tasks11_20.Task19();
                        break;
                    case 20:
                        tasks11_20.Task20();
                        break;
                    case 21:
                        tasks21_27.Task21();
                        break;
                    case 22:
                        tasks21_27.Task22();
                        break;
                    case 23:
                        tasks21_27.Task23();
                        break;
                    case 24:
                        tasks21_27.Task24();
                        break;
                    case 25:
                        tasks21_27.Task25();
                        break;
                    case 26:
                        tasks21_27.Task26();
                        break;
                    case 27:
                        tasks21_27.Task27();
                        break;
                    default:
                        Console.WriteLine("Вы нажали неизвестный символ");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
