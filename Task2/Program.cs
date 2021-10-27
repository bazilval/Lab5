using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Сформировать одномерный массив из 15 элементов, 
 * которые выбираются случайным образом из диапазона [0; 50]. 
 * Определить сумму максимального и минимального элементов массива.*/
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[15];
            int min, max;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 50);
                Console.Write($"{arr[i]} ");
            }
            min = max = arr[0];
            foreach (int e in arr)
            {
                min = (e < min) ? e : min;
                max = (e > max) ? e : max;
            }
            Console.WriteLine($"\nСумма максимального и минимального = {min+max}");
            Console.ReadKey();
        }
    }
}
