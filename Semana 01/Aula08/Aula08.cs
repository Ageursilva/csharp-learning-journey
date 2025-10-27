using System;
//Entrada de dados
//Conversão simples
class Aula08
{
    static void Main()
    {
        int v1, v2, soma;
        string nome;
        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        soma = v1 + v2;
        Console.Write("A soma de : {0} + {1} é igual a {2} ", v1, v2, soma);

    }

}