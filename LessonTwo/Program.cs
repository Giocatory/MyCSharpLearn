using System;

namespace LessonTwo
{
    internal class Program
    {
        private static void Main()
        {
            (int, float, double) tuple = (30, 30.123456789985201478622001485652214151656F, 30.1234567889);
            Console.WriteLine($"{tuple.Item1:C}"); // 30 PУБ
            Console.WriteLine($"{tuple.Item1:d5}"); // 00030
            Console.WriteLine($"{tuple.Item2:e}"); // 3.012346e+001
            Console.WriteLine($"{tuple.Item3:F2}"); // 30.12
            Console.WriteLine($"{tuple.Item1:X}"); // 1E

            Console.WriteLine("\nDefault variable: ");
            int num = default;
            string line = default;
            object obj = default;
            bool bl = default;
            char ch = default;
            Console.WriteLine($"Num: {num}"); // 0
            Console.WriteLine($"String: {line}"); // null
            Console.WriteLine($"Object: {obj}"); // null
            Console.WriteLine($"Boolean: {bl}"); // false
            Console.WriteLine($"Char: {ch}"); // Empty symbol

            Console.WriteLine($"\nInt16 max value: {Int16.MaxValue}");
            Console.WriteLine($"Int16 min value: {Int16.MinValue}");

            Console.WriteLine($"\nInt32 max value: {Int32.MaxValue}");
            Console.WriteLine($"Int32 min value: {Int32.MinValue}");

            Console.WriteLine($"\nInt64 max value: {Int64.MaxValue}");
            Console.WriteLine($"Int64 min value: {Int64.MinValue}");

            Console.WriteLine("\nChar type Functionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit ('a') : {0}", char.IsDigit(myChar)); // false
            Console.WriteLine("char.IsLetter ('a’) : {0}", char.IsLetter(myChar)); // true
            Console.WriteLine("char.IsWhiteSpace('Hello There’, 5): {0}", char.IsWhiteSpace("Hello There", 5)); // true
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6)); // false
            Console.WriteLine("char.IsPunctuation(’?'): {0}", char.IsPunctuation('?')); // true
            Console.ReadKey();
        }
    }
}