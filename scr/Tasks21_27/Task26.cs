using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Starter
{
    public class Task26
    {
        public void Task()
        {
            int[] array = { 1, 2, 4, 5, 6, 7, 9, 3, 3 };
            foreach (var i in array)
                Console.WriteLine(i + " ");

            Console.WriteLine("Введите число:");
            var vs = Convert.ToInt32(Console.ReadLine());
            Add(array, vs);

            Console.ReadLine();

        }
        public int[] Add(int[] array, int value)
        {
            int[] vs = { value };
            var result = vs.Concat(array).ToArray();
            foreach (var i in result)
            {
                var s = string.Join(" ", result);
                Console.WriteLine(s);
                break;
            }
            string v = String.Concat<int>(result);
            Console.WriteLine();
            result[1] = Convert.ToInt32(v);
            foreach (int i in result)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine();
            return result;
        }
    }
}
