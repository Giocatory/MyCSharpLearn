using System;
using System.Text;

namespace LessonThree
{
    internal class Program
    {
        private static void Main()
        {
            string s1 = "Hello";
            string s2 = "Mikle";
            string s3 = s1 + " " + s2;

            Console.WriteLine(s3); // Hello Mikle
            Console.WriteLine(s1 == s2); // false
            Console.WriteLine(s1.Equals(s2)); // false
            Console.WriteLine(s1.Equals(s1)); //true
            Console.WriteLine("hello".Equals(s1)); // false
            Console.WriteLine(s1 == "hello"); // false
            Console.WriteLine("hello".ToUpper().Equals(s1.ToUpper())); //true
            Console.WriteLine(s1.Equals("hello", StringComparison.CurrentCultureIgnoreCase)); //true

            //################################################################################

            Console.WriteLine("\nString Builder");
            StringBuilder sb = new("### Hi Mikhail ###");
            sb.Append('\n');
            sb.AppendLine("World of Warcraft...");
            sb.AppendLine("Albion");
            sb.AppendLine("Aion 2");
            sb.AppendLine("Lineage 2");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", "God in me!"); // looking for "2" in the entire row and if it finds, then replaces the value everywhere
            Console.WriteLine(sb.ToString());
            Console.WriteLine($"sb length - {sb.Length}"); // 66

            //################################################################################
            Console.WriteLine("\nDynamic variable");
            dynamic variable = 15;
            Console.WriteLine(variable);
            variable = "Mikhail";
            Console.WriteLine(variable);
        }
    }
}