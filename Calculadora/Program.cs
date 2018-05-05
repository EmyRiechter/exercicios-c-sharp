using System;

namespace Calculadora
{
    public class Program
    {

        public static void Main(string[] args)
        {

            int num1, num2, opcao = 5;


            do
            {

                Console.WriteLine("\nO que deseja realizar?");
                Console.WriteLine("[1] Soma");
                Console.WriteLine("[2] Subtração");
                Console.WriteLine("[3] Multiplicação");
                Console.WriteLine("[4] Divisão");
                Console.WriteLine("[5] Sair");

                Console.WriteLine("Sua opção:  ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: //soma
                        Console.WriteLine("Digite o primeiro numero:  ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o primeiro numero:  ");
                        num2 = int.Parse(Console.ReadLine());

                        Soma(num1, num2);

                        break;

                    case 2: //subtração
                        Console.WriteLine("Digite o primeiro numero:  ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero: ");
                        num2 = int.Parse(Console.ReadLine());

                        Subtracao(num1, num2);

                        break;

                    case 3: //multiplicação
                        Console.WriteLine("Digite o primeiro numero:  ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o primeiro numero:  ");
                        num2 = int.Parse(Console.ReadLine());

                        Multiplicacao(num1, num2);

                        break;

                    case 4: //divisão
                        Console.WriteLine("Digite o primeiro numero:  ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o primeiro numero:  ");
                        num2 = int.Parse(Console.ReadLine());

                        Divisao(num1, num2);

                        break;

                    case 5:
                        Console.WriteLine("Saindo do programa...");
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }


            } while (opcao != 5);

        }

        public static void Soma(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("\nO resultado é: " + resultado);
        }
        public static void Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            Console.WriteLine("\nO resultado é: " + resultado);
        }
        public static void Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            Console.WriteLine("\nO resultado é: " + resultado);
        }
        public static void Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            Console.WriteLine("\nO resultado é: " + resultado);
        }
    }
}