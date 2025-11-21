using System;

class Program
{
    static void Main()
    {
        int idade;
        char temCarteira;
        int experiencia;

        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Tem carteira de motorista? (s/n): ");
        temCarteira = char.Parse(Console.ReadLine());

        Console.Write("Anos de experiência: ");
        experiencia = int.Parse(Console.ReadLine());

        VerificarHabilitacao(idade, temCarteira, experiencia);
    }

    static void VerificarHabilitacao(int idade, char temCarteira, int experiencia)
    {
        // IFs aninhados combinados com operadores lógicos
        if (idade >= 18)
        {
            if (char.ToUpper(temCarteira) == 'S')
            {
                Console.WriteLine("Você pode dirigir.");

                if (experiencia > 0)
                {
                    if (experiencia >= 5)
                    {
                        Console.WriteLine("Motorista experiente!");
                    }
                    else
                    {
                        Console.WriteLine("Motorista iniciante.");
                    }
                }
                else
                {
                    Console.WriteLine("Motorista sem experiência.");
                }
            }
            else
            {
                Console.WriteLine("Você precisa ter carteira para dirigir.");
            }
        }
        else
        {
            Console.WriteLine("Você é menor de idade e não pode dirigir.");
        }
    }
}