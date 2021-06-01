using System;

namespace LessonThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "Mikle";
            string s3 = s1 + " " + s2;

            Console.WriteLine(s3);
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s1));
            Console.WriteLine("hello".Equals(s1));
            Console.WriteLine(s1 == "hello");
            Console.WriteLine("hello".ToUpper().Equals(s1.ToUpper()));
            Console.WriteLine(s1.Equals("hello", StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
