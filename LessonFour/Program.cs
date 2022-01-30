using System;
using System.Linq;

namespace LessonFour
{
    internal class Program
    {
        private static void Main()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 4, 5, 6, 7, 8 };
            // LINQ query
            var subset = from i in numbers where i < 11 select i; // var == System.Collections.Generic.IEnumerable<int>

            foreach (var k in subset) // var == int
            {
                Console.Write($"{k} "); // 10 1 2 3 4 5 6 7 8
            }
            Console.WriteLine();
            Console.WriteLine(subset.GetType().Name); // WhereArrayIterator`1
            Console.WriteLine(subset.GetType().Namespace); // System.Linq
            Console.WriteLine(subset.GetType().BaseType); // System.Linq.Enumerable+Iterator`1[System.Int32]

            //##############################################################################################

            Console.WriteLine("\nArray two rank");
            // Initialization of array
            int[,] nums = new int[3, 3]; // 3 rows and 3 column
            int rows = nums.GetUpperBound(0) + 1;
            int columns = nums.Length / rows;
            int count = 1;
            // Assignment of values ​​for each arrays
            for (int i = 1; i <= rows; i++)
            {
                for (int k = 1; k <= columns; k++)
                {
                    nums[i - 1, k - 1] = count;
                    count++;
                }
            }
            // Conclusion on the console
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < columns; k++)
                {
                    Console.Write($"{nums[i, k]} ");
                }
                Console.WriteLine();
            }

            //##############################################################################################

            Console.WriteLine("\nArray arrays");
            int[][] numerics = new int[3][];
            int counter = 1;
            // Initialization of arrays
            for (int i = 0; i < numerics.Length; i++)
            {
                numerics[i] = new int[i + 7];
            }
            // Assignment of values ​​for each arrays
            for (int i = 0; i < numerics.Length; i++)
            {
                for (int j = 0; j < numerics[i].Length; j++)
                {
                    numerics[i][j] = counter;
                    counter++;
                }
            }
            // Conclusion on the console
            foreach (int[] i in numerics)
            {
                foreach (int j in i)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }

            //##############################################################################################

            Console.WriteLine("\nCopy and Sort Array");

            char[] words = { 'a', 'b', 'f', 'o', 'p', 'z', 'q', 'r' };
            char[] newWords = new char[words.Length];

            Console.WriteLine("Source array");
            foreach (char word in words)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine();
            Console.WriteLine("Sorted Array");
            Array.Sort(words);
            foreach (char word in words)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine();
            Console.WriteLine("Copy array:\nNewWords:");
            Array.Copy(words, newWords, words.Length);
            foreach (char word in newWords)
            {
                Console.Write($"{word} ");
            }
        }
    }
}