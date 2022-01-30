namespace ClassLibrary
{
    public class Fibbonaci
    {
        private int number;
        private int[] fibMass;

        public Fibbonaci(int rangeNumber)
        {
            number = rangeNumber;
            fibMass = new int[rangeNumber];
        }

        public void Show()
        {
            for (int i = 0; i < fibMass.Length; i++)
            {
                if (i == 0)
                {
                    fibMass[i] = i;
                    continue;
                }
                if (i == 1)
                {
                    fibMass[i] = i;
                    continue;
                }
                fibMass[i] = fibMass[i - 1] + fibMass[i - 2];
            }
            foreach (var i in fibMass)
            {
                Console.Write($"{i} ");
            }
        }
    }
}