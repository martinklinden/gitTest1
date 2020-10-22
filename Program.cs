using System;

namespace gitTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world!");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}^2 = {1}", i, i * i);
                Console.ReadKey();
            }
        }
    }
}
