using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Digite um numero: ");
                long n = long.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine("O número " + n + " é par" + Environment.NewLine);

                }
                else
                {

                    Console.WriteLine("O número " + n + " é impar" + Environment.NewLine);
                }

            }

        }

    }
    
}



