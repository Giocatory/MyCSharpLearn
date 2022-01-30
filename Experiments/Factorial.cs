namespace Experiments
{
    internal class Factorial
    {
        public static void Show(int numberRange)
        {
            for (int i = 0; i < numberRange; i++)
            {
                if (i == 0 && i == 1)
                {
                    Console.WriteLine($"{i} = 1");
                }
                else
                {
                    long factorial = 1L;
                    for (int j = 1; j <= i; j++)
                    {
                        factorial *= (long)j;
                    }
                    Console.WriteLine($"{i} = {factorial}");
                }
            }
        }
    }
}
