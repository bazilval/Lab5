using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Запросить у пользователя целочисленное значение N.
 * Сформировать двумерный массив размера NxN. 
 * Заполнить массив числами, вводимыми с клавиатуры.
 * Проверить, является ли введенная с клавиатуры матрица магическим квадратом. 
 * Магическим квадратом называется матрица, сумма элементов которой в каждой строке, 
 * в каждом столбце и по каждой диагонали одинакова.*/
namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = Int32.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            int total = 0, checkSum = 0, cursor = 0;
            string text = "";

            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("Ввод:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1}-я строка:");
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                    text = $"{text} {{{arr[i, j]}}}";
                    total += 2 * arr[i, j];
                    if ((j == i) || (j == n - 1 - i)) total += arr[i, j];
                    if ((j == i) && (j == n - 1 - i)) total += arr[i, j];
                    if (i == 0) checkSum += arr[i, j];
                }
                cursor = Console.CursorTop;
                Console.SetCursorPosition(0, 2 + i);
                Console.WriteLine(text);
                text = "";
                Console.SetCursorPosition(0, cursor);
            }
            Console.WriteLine("Результат:");
            text = ((total / (2 * n + 2)) == checkSum) ? "Это магический квадрат, вау!" : "Это что еще за случайный набор символов?";
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
