using System;
// Else
class Program
{
    static void Main()
    {
        Console.Write("Digite a nota do aluno (0-100): ");
        double nota = double.Parse(Console.ReadLine());

        string conceito;

        // Estrutura if else if else para classificar a nota
        if (nota >= 90 && nota <= 100)
        {
            conceito = "A";
            Console.WriteLine($"Nota: {nota} - Conceito: {conceito} - Excelente!");
        }
        else if (nota >= 80 && nota < 90)
        {
            conceito = "B";
            Console.WriteLine($"Nota: {nota} - Conceito: {conceito} - Muito Bom!");
        }
        else if (nota >= 70 && nota < 80)
        {
            conceito = "C";
            Console.WriteLine($"Nota: {nota} - Conceito: {conceito} - Bom!");
        }
        else if (nota >= 60 && nota < 70)
        {
            conceito = "D";
            Console.WriteLine($"Nota: {nota} - Conceito: {conceito} - Regular!");
        }
        else if (nota >= 0 && nota < 60)
        {
            conceito = "F";
            Console.WriteLine($"Nota: {nota} - Conceito: {conceito} - Reprovado!");
        }
        else
        {
            Console.WriteLine("Nota inválida! Digite um valor entre 0 e 100.");
        }
    }
}