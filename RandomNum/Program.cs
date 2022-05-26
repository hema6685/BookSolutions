using System;

namespace RandomNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomInt = random.Next(10);
            Console.WriteLine(randomInt);

            int dieRoll = random.Next(1, 7);
            Console.WriteLine(dieRoll);

            int zeroToNine = random.Next(10);
            Console.WriteLine(zeroToNine);

            double randomDouble = random.NextDouble();
            Console.WriteLine(randomDouble * 100);
            Console.WriteLine((float)randomDouble * 100F);
            Console.WriteLine((decimal)randomDouble * 100M);

            int zeroOrOne = random.Next(2);
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(coinFlip);
        }
    }
}
