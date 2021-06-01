using System;
using System.Linq;

namespace LessonFour
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
