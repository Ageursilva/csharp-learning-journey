using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecione a operação de calculo que deseja fazer");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Juros Composto");
            Console.WriteLine("6 - Sair");

            Console.WriteLine("------------------");

            Console.WriteLine("Selecine uma opção: ");
            short res = short.Parse(Console.ReadLine());
            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: JurosComposto(); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break;


            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração  é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação  é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão  é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void JurosComposto()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor inicial: ");
            decimal capital = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a taxa de juros (ex: 0,05 para 5%): ");
            decimal taxa = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de meses: ");
            int meses = int.Parse(Console.ReadLine());
            decimal montante = capital;

            for (int mesAtual = 1; mesAtual <= meses; mesAtual++)
            {
                montante = montante * (1 + taxa);
                Console.WriteLine($"Mês {mesAtual}: {montante:C2}");
            }
            Console.WriteLine($"O montante final após {meses} meses é {montante:C2}");
            Console.ReadKey();
            Menu();
        }

    }
}

