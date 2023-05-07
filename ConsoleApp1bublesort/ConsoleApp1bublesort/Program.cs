using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1bublesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[10];
            for (int i=0; i<numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);
            }

            Console.WriteLine("Array to be sorted: );
            foreach (var number  in numbers)
            {
                Console.WriteLine(number + " " );
            }

            Console.WriteLine();

            BubbleSort(numbers);

            Console.ReadLine();
        }

        private static void BubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length -1; i++) 
            { 
              for (int j = 0; j < numbers.Length -1; j++)
                {
                   if (numbers[i] > numbers[j + 1])
                }
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
            Console.WriteLine("The sorted array of numbers: ");
            foreach (var number in numbers) 
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
