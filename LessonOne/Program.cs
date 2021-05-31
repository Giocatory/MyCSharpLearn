using System;

namespace LessonOne
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine($"System process: {System.Diagnostics.Process.GetCurrentProcess()}");
            Console.WriteLine($"Current directory: {Environment.CurrentDirectory}");
            Console.WriteLine($"Current Managed Thread ID: {Environment.CurrentManagedThreadId}");
            Console.WriteLine("Logical Drives: ");
            GetDrivers();
            Console.WriteLine($"System is 64bit?: {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"OS version: {Environment.OSVersion}");
            Console.WriteLine($"Machine name: {Environment.MachineName}");
            Console.WriteLine($".NET version: {Environment.Version}");
            Console.WriteLine($"System directory: {Environment.SystemDirectory}");
            Console.ReadKey();
        }
        static void GetDrivers()
        {
            String[] drivers = Environment.GetLogicalDrives();
            foreach (var drive in drivers)
            {
                Console.WriteLine(drive);
            }
        }
    }
}
