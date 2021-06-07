using System;

namespace LessonFive
{
    class Program
    {
        static void Main()
        {
            // init tuple
            (string, int, DateTime) tipicalTuple;
            {
                tipicalTuple = ("Mikhail", 32, DateTime.Now);
                Console.WriteLine($"Name {tipicalTuple.Item1}");
                Console.WriteLine($"Age {tipicalTuple.Item2}");
                Console.WriteLine($"Date time: {tipicalTuple.Item3}");
                Console.WriteLine();
            }
            // tuple with var (Variables with VAR must be initialized immediately!!!)
            var tipicalVarTuple = ("Tatyana", 31, DateTime.Now);
            {
                Console.WriteLine($"Name {tipicalVarTuple.Item1}");
                Console.WriteLine($"Age {tipicalVarTuple.Item2}");
                Console.WriteLine($"Date time: {tipicalVarTuple.Item3}");
                Console.WriteLine();
            }

            // tuple with name items
            (string name, double age, DateTime date) tipicalNamesTuple = (name: "Margo", age: 2.5, date: DateTime.Now);
            {
                Console.WriteLine($"Name {tipicalNamesTuple.name}");
                Console.WriteLine($"Age {tipicalNamesTuple.age}");
                Console.WriteLine($"Date time: {tipicalNamesTuple.date}");
                Console.WriteLine();
            }

            // or we can delete tuple name
            (string name, double age, DateTime date) = ("Margo", 2.5, DateTime.Now);
            {
                Console.WriteLine($"Name {name}");
                Console.WriteLine($"Age {age}");
                Console.WriteLine($"Date time: {date}");
                Console.WriteLine();
            }

            // get returned tuple
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            DateTime userDateWrite = DateTime.Now;

            var fullPersonInfo = PersonalInfo(userName, userAge, userDateWrite);
            Console.WriteLine();
            Console.WriteLine($"User name: {fullPersonInfo.Item1}");
            Console.WriteLine($"User age: {fullPersonInfo.Item2}");
            Console.WriteLine($"Date from write info about user: {fullPersonInfo.Item3}");
            
        }
        // Returned tuple
        static (string, int, DateTime) PersonalInfo(string name, int age, DateTime nowDate)
        {
            return (name, age, nowDate);
        }
    }
}
