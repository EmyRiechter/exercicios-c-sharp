using System;

namespace MostraNome
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string nome;
                Console.WriteLine("Qual seu nome? ");
                nome = Console.ReadLine();
                Console.WriteLine("Olá " + nome + Environment.NewLine);

            } while (true);

        }
    }
}
