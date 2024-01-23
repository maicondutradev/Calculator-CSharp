using System;
using System.Reflection;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();

                Console.WriteLine(" ");
                Console.WriteLine("Deseja continuar?  (S)Sim  (N)Não");
                var decisao = Console.ReadLine();


                if (decisao.ToLower() == "s")
                {
                    continue;
                }
                else if (decisao.ToLower() == "n")
                {
                    break;
                }
            }
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Digite o número do calculo que deseja fazer: Soma(1) Subtração(2) Divisão(3) Multiplicação(4)");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                default:
                    Console.WriteLine("Escolha inválida, tente novamente!");
                    Menu();
                    break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("SOMA");
            Console.WriteLine("--------");
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é {resultado}");

        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("SUBTRAÇÃO");
            Console.WriteLine("--------");
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtração é {resultado}");

        }


        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("DIVISÃO");
            Console.WriteLine("--------");
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {resultado}");
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("MULTIPLICAÇÃO");
            Console.WriteLine("--------");
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é {resultado}");
        }

    }



}