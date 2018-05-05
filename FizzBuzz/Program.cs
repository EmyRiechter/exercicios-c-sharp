using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            for (n = 1; n <= 100; n++)

                if (n % 3 == 0 && n % 5 == 0)
                {
                    Console.WriteLine("FizBuzz");
                }
                else if (n % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (n % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(n);
                }
                
        }
    }
}
