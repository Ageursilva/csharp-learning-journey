using System;


class form
{
    static void Main()
    {
        string nome, profissao, email;
        int idade;
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Qual sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.Write("Qual sua profissão: ");
        profissao = Console.ReadLine();
        Console.Write("Qual seu email: ");
        email = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Nome: {0} ", nome);
        Console.WriteLine("Idade: {0} ", idade);
        Console.WriteLine("E-mail: {0} ", email);
        Console.WriteLine("Profissão: {0} ",profissao);




    }
}