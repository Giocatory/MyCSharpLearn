using System;

namespace LessonOne
{
    internal class Program
    {
        private static void Main(String[] args)
        {
            // работа с системными инструментами
            Console.Write("Please write name this console: ");
            string consoleName = Console.ReadLine();
            Console.Title = consoleName;
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("System information:");
            Console.ResetColor();
            Console.WriteLine($"User: {Environment.UserName}");
            Console.WriteLine($"System process: {System.Diagnostics.Process.GetCurrentProcess()}");
            Console.WriteLine($"Current directory: {Environment.CurrentDirectory}");
            Console.WriteLine($"Current Managed Thread ID: {Environment.CurrentManagedThreadId}");
            Console.WriteLine("Logical Drives: ");
            GetDrivers();
            Console.WriteLine($"how much processors: {Environment.ProcessorCount}");
            Console.WriteLine($"System is 64bit?: {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"OS version: {Environment.OSVersion}");
            Console.WriteLine($"Machine name: {Environment.MachineName}");
            Console.WriteLine($".NET version: {Environment.Version}");
            Console.WriteLine($"System directory: {Environment.SystemDirectory}");
            Console.ReadKey();
        }

        private static void GetDrivers()
        {
            String[] drivers = Environment.GetLogicalDrives();
            foreach (var drive in drivers)
            {
                Console.WriteLine(drive);
            }
        }
    }
}