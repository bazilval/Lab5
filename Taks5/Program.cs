using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:
*1 0 1 0 1
*0 1 0 1 0
*1 0 1 0 1*/
namespace Taks5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = Int32.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = Math.Abs(((j + 1) % 2) - (i % 2));
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
