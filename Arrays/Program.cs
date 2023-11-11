//#define ARRAYS_1
//#define ARRAYS_2
#define JAGGED_ARRAYS
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if ARRAYS_1
            Console.Write("Введите размер массива ");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] arr= new int[n];
            Random rand= new Random(0);// c 0 псевдослучайность
            for(int i=0; i<arr.Length; i++)
            {
                arr[i]=rand.Next(100,200);//100 нижний 200 верхний пределы
            }
            for (int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine();
            foreach(int i in arr) //перебор массива
            {
            Console.Write(i+"\t");
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов массива: {arr.Sum()}");
            Console.WriteLine($"Среднее арифметическое массива: {arr.Average()}");
            Console.WriteLine($"Минимальное значение массива: {arr.Min()}");
            Console.WriteLine($"Максимальное значение массива: {arr.Max()}");
            Array.Sort(arr);
            foreach(int i in arr) 
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
#endif //ARRAYS_1
#if ARRAYS_2
            Random  rand= new Random(0);
            Console.Write("Введите количество строк ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество элементов строки ");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[rows, cols];
            Console.WriteLine($"Количество измерений массива: {arr.Rank}");
            Console.WriteLine($"Количество строк массива: {arr.GetLength(0)}");
            Console.WriteLine($"Количество элементов в строке массива: {arr.GetLength(1)}");
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++) 
                {
                    arr[i,j]=rand.Next(100);
                }
            }
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++) 
                {
                    Console.Write(arr[i,j]+ "\t");
                }
                Console.WriteLine();
            }
            foreach(int i in arr) 
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов массива {arr.Cast<int>().Sum()}");//Cast преобразует двумерный в одномерный что позволяет использовать методы из одномерного
            Console.WriteLine($"Среднее арифетическое элементов массива {arr.Cast<int>().Sum() / arr.Length}");
            Console.WriteLine($"Максимальный элемент массива {arr.Cast<int>().Max()}");
            Console.WriteLine($"Минимальный элемент массива {arr.Cast<int>().Min()}");

#endif //ARRAYS_2
#if JAGGED_ARRAYS
            int[][] arr = new int[][]
            {
                new int[] { 0, 1,1,2 },
                new int[] {3,5,8 },
                new int[] {13,21 },
                new int[] {34,55,89}
            };
            for(int i = 0; i < arr.Length; i++) 
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            int count = 0;
            int min = arr[0][0];
            int max = arr[0][0];
            for(int i = 0; i < arr.Length; i++) 
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    sum+=arr[i][j];
                    count++;
                    if (min > arr[i][j]) min= arr[i][j];
                    if (max < arr[i][j]) max= arr[i][j];
                }
            }
            Console.WriteLine($"Сумма элементов массива {sum}");
            Console.WriteLine($"Среднее арифетическое элементов массива {sum / count}");
            Console.WriteLine($"Максимальный элемент массива {max}");
            Console.WriteLine($"Минимальный элемент массива {min}");
#endif //#JAGGED_ARRAYS
        }
    }
}
