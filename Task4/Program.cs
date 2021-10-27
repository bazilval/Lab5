using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].
 * Определить количество нечетных положительных элементов, стоящих на четных местах.*/
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int count = 0;
            Random random = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-50, 50);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (((i + 1) % 2 == 0) && (arr[i] % 2 != 0) && (arr[i] > 0))
                {
                    count++;
                }
            }
            Console.WriteLine($"Искомое количество = {count}");
            Console.ReadKey();
        }
    }
}
