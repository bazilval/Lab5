using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50].
 * Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.*/
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            Random random = new Random();
            int[] arr = new int[n];
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-50, 50);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (arr[i]>arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.Write($"{arr[i]} ");
            }

            for (int i = 5; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.Write($"{arr[i]} ");
            }
            Console.ReadKey();
        }
    }
}
