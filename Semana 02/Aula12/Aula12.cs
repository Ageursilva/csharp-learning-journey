using System;
// Condicional IF
class Aula12
{

    static void Main()
    {
        int nota = 80;
        string resultado = "Reprovado";
        if (nota >= 60)
        {
            resultado = "Aprovado";
        }
        Console.WriteLine($"Resultado: {resultado}");

    }
}