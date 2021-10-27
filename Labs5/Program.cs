using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Сформировать одномерный массив из 7 элементов.
 * Заполнить массив числами, вводимыми с клавиатуры, 
 * определить среднее арифметическое элементов.*/
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[7];
            float sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите значение элемента {i+1}: ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            foreach (int e in arr)
            {
                sum += e;
            }
            Console.WriteLine($"Среднее арифметическое массива = {sum/arr.Length,3:f3}");
            Console.ReadKey();
        }
    }
}
